using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryClient.Controls {
    public partial class KolcsonzesUj : UserControl {
        List<Konyv> konyvek = new List<Konyv>();
        List<Olvaso> olvasok = new List<Olvaso>();
        public KolcsonzesUj() {
            InitializeComponent();
        }

        private async void btn_KeresKonyv_Click(object sender, EventArgs e) {
            if (konyvek.Count != 0) konyvek.Clear();
            using (var client = new HttpClient()) {
                string cim = " ";
                string iro = " ";
                if (!string.IsNullOrEmpty(tb_Cim.Text)) cim = tb_Cim.Text;
                if (!string.IsNullOrEmpty(tb_Szerzo.Text)) iro = tb_Szerzo.Text;

                var response = await client.GetAsync(new Uri($"http://localhost:5000/api/Konyv/{cim}/{iro}/false"));
                if (response.IsSuccessStatusCode) {
                    var jsonStream = await response.Content.ReadAsStringAsync();
                    konyvek = JsonConvert.DeserializeObject<List<Konyv>>(jsonStream);
                    if (konyvek.Count() == 0) { lb_Message.Text = "Nincs ilyen könyv!"; }
                    else {
                        App.Instance.listboxRefresh(lbox_Konyv, konyvek);
                    }
                }
            }
        }

        private async void btn_KeresOlvaso_Click(object sender, EventArgs e) {
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
                            App.Instance.listboxRefresh(lbox_Olvaso, olvasok);
                        }
                    }
                }
                else lb_Message.Text = "Adjon meg egy nevet!";
            }
        }

        private async void btn_OK_Click(object sender, EventArgs e) {
            Kolcsonzes uj = new Kolcsonzes();
            uj.Datum = dateTimePicker.Value;

            int idx = lbox_Konyv.SelectedIndex;
            if (idx == -1) lb_Message.Text = "Nincs kiválasztva egy könyv sem!";
            else {
                uj.KonyvId = konyvek[idx].id;
            }

            idx = lbox_Olvaso.SelectedIndex;
            if (idx == -1) lb_Message.Text = "Nincs kiválasztva egy olvasó sem!";
            else {
                uj.OlvasoId = olvasok[idx].Id;
            }

            using (var client = new HttpClient()) {
                var json = JsonConvert.SerializeObject(uj);
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                var response = await client.PostAsync(new Uri($"http://localhost:5000/api/Kolcsonzes"), stringContent);
                if (response.IsSuccessStatusCode) {
                   lb_Message.Text = "Sikeres kölcsönzés!";
                    
                }
            }
        }
    }
}
