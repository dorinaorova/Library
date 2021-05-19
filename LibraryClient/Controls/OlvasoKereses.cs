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

namespace LibraryClient.Controls {
    
    public partial class OlvasoKereses : UserControl {
        private List<Olvaso> olvasok = new List<Olvaso>();
        public OlvasoKereses() {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e) {
            int idx = listBox.SelectedIndex;
            if (idx == -1) lb_Message.Text = "Nincs kiválasztva egy olvasó sem!";
            else {
                Olvaso o = olvasok[idx];
                App.Instance.OlvasoModositas(o);
            }
        }

        private async void btn_Keres_Click(object sender, EventArgs e) {
            if (olvasok.Count != 0) olvasok.Clear();
            using (var client = new HttpClient()) {
                string nev;
                if (!string.IsNullOrEmpty(tb_Nev.Text)) {
                    nev = tb_Nev.Text;
                    var response = await client.GetAsync(new Uri($"http://localhost:5000/api/Olvaso/{nev}"));
                    if (response.IsSuccessStatusCode) {
                        var jsonStream = await response.Content.ReadAsStringAsync();
                        olvasok = JsonConvert.DeserializeObject<List<Olvaso>>(jsonStream);
                        if (olvasok.Count() == 0) { lb_Message.Text = "Nincs ilyen olvasó!"; }
                        else {
                            App.Instance.listboxRefresh(listBox, olvasok);
                        }
                    }
                }
                else lb_Message.Text = "Adjon meg egy nevet!";
            }
        }

        private async void btn_Ossz_Click(object sender, EventArgs e) {
            if (olvasok.Count != 0) olvasok.Clear();
            using (var client = new HttpClient()) {
                    var response = await client.GetAsync(new Uri($"http://localhost:5000/api/Olvaso"));
                    if (response.IsSuccessStatusCode) {
                        var jsonStream = await response.Content.ReadAsStringAsync();
                        olvasok = JsonConvert.DeserializeObject<List<Olvaso>>(jsonStream);
                    App.Instance.listboxRefresh(listBox, olvasok);
                }
                
                else lb_Message.Text = "Adjon meg egy nevet!";
            }
        }

        private async void btn_Delete_Click(object sender, EventArgs e) {
            int idx = listBox.SelectedIndex;
            if (idx == -1) lb_Message.Text = "Nincs kiválasztva egy olvasó sem!";
            else {
                Olvaso o = olvasok[idx];
                int olvasoId = o.Id;

                using (var client2 = new HttpClient()) {
                    var response2 = await client2.GetAsync(new Uri($"http://localhost:5000/api/Kolcsonzes/{olvasoId}")); //kolcsonzesek lekerdezese
                    if (response2.IsSuccessStatusCode) {
                        var jsonStream = await response2.Content.ReadAsStringAsync();
                        List<Kolcsonzes> kolcsonzesek = new List<Kolcsonzes>();
                        kolcsonzesek = JsonConvert.DeserializeObject<List<Kolcsonzes>>(jsonStream);
                        foreach (var item in kolcsonzesek) {
                            using (var client3 = new HttpClient()) { //konyv: kolcsonozve = false
                                int id = item.id;
                                int konyvId = item.KonyvId;
                                Konyv uj = item.Konyv;
                                uj.kolcsonozve = false;
                                var json = JsonConvert.SerializeObject(uj);
                                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                                var response3 = await client3.PutAsync(new Uri($"http://localhost:5000/api/Konyv/{konyvId}"), stringContent);
                                if (response3.IsSuccessStatusCode) {
                                    using (var client4 = new HttpClient()) {
                                        var response = await client4.DeleteAsync(new Uri($"http://localhost:5000/api/Kolcsonzes/{id}")); //kolcsonzes torlese
                                    }
                                }
                            }

                        }
                    }
                }

                using (var client = new HttpClient()) { //olvaso tolrese
                    var response = await client.DeleteAsync(new Uri($"http://localhost:5000/api/Olvaso/{olvasoId}"));
                    if (response.IsSuccessStatusCode) {
                        lb_Message.Text = "Sikeres törlés!";
                        olvasok.Remove(o);
                        App.Instance.listboxRefresh(listBox, olvasok);
                    }
                }
            }
        }
    }
}
