using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryClient {
    public partial class OlvasoModositasForm : Form {
        Olvaso activeOlvaso;
        List<Kolcsonzes> kolcsonzesek= new List<Kolcsonzes>();
        public OlvasoModositasForm(Olvaso o) {
            activeOlvaso = o;
            InitializeComponent();
            tb_Nev.Text = activeOlvaso.Nev;
            dtp_Szul.Value = activeOlvaso.Szul;

            KolcsonzesLista();
        }

        private async void btn_OK_Click(object sender, EventArgs e) {
            activeOlvaso.Nev = tb_Nev.Text;
            activeOlvaso.Szul = dtp_Szul.Value;
            using (var client = new HttpClient()) {
                int id = activeOlvaso.Id;
                var json = JsonConvert.SerializeObject(activeOlvaso);
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                var response = await client.PutAsync(new Uri($"http://localhost:5000/api/Olvaso/{id}"), stringContent);
            }
            this.Close();
        }

        public async void KolcsonzesLista() {
            using (var client = new HttpClient()) {
                int id = activeOlvaso.Id;
                var response = await client.GetAsync(new Uri($"http://localhost:5000/api/Kolcsonzes/{id}"));
                if (response.IsSuccessStatusCode) {
                    var jsonStream = await response.Content.ReadAsStringAsync();
                    kolcsonzesek = JsonConvert.DeserializeObject<List<Kolcsonzes>>(jsonStream);
                    if (kolcsonzesek.Count > 0)
                        App.Instance.listboxRefresh(listBox1, kolcsonzesek);
                }
            }
        }

        private async void btn_Vissza_Click(object sender, EventArgs e) {
            int idx = listBox1.SelectedIndex;
            int id = kolcsonzesek[idx].id;
            using (var client = new HttpClient()) {
                var response = await client.DeleteAsync(new Uri($"http://localhost:5000/api/Kolcsonzes/{id}")); //kolcsonzes torlese
                if (response.IsSuccessStatusCode) {
                    using (var client2 = new HttpClient()) { //konyvek frissitese
                        int konyvId = kolcsonzesek[idx].KonyvId;
                        Konyv uj = kolcsonzesek[idx].Konyv;
                        uj.kolcsonozve = false;
                        var json = JsonConvert.SerializeObject(uj);
                        var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                        var response2 = await client2.PutAsync(new Uri($"http://localhost:5000/api/Konyv/{konyvId}"), stringContent);
                        if (response2.IsSuccessStatusCode) {
                            kolcsonzesek.RemoveAt(idx);
                            App.Instance.listboxRefresh(listBox1, kolcsonzesek);
                        }
                    }

                }
            }
        }
    }
}
