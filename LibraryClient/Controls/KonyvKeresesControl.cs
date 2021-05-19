using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryClient {
    public partial class KonyvKeresesControl : UserControl {
        private List<Konyv> konyvek = new List<Konyv>();
        public KonyvKeresesControl() {
            InitializeComponent();
            rb_passz.Checked = true;
        }


        private void btn_Update_Click(object sender, EventArgs e) {
            int idx = listBox1.SelectedIndex;
            if (idx == -1) lb_Message.Text = "Nincs kiválasztva egy könyv sem!";
            else {
                Konyv k = konyvek[idx];
                App.Instance.KonyvModositas(k);
            }
        }

        private async void btn_Keres_ClickAsync(object sender, EventArgs e) {
            if(konyvek.Count!=0)  konyvek.Clear();
            using (var client = new HttpClient()) {
                string cim = " ";
                string iro = " ";
                string kolcs = " ";
                if (!string.IsNullOrEmpty(tb_Cim.Text)) cim = tb_Cim.Text;
                if (!string.IsNullOrEmpty(tb_Iro.Text)) iro = tb_Iro.Text;
                if (rb_Igen.Checked == true) kolcs = "true";
                else if (rb_Nem.Checked == true) kolcs = "false";

                var response = await client.GetAsync(new Uri($"http://localhost:5000/api/Konyv/{cim}/{iro}/{kolcs}"));
                if (response.IsSuccessStatusCode) {
                    var jsonStream = await response.Content.ReadAsStringAsync();
                    konyvek = JsonConvert.DeserializeObject<List<Konyv>>(jsonStream);
                    if (konyvek.Count() == 0) { lb_Message.Text = "Nincs ilyen könyv!"; }
                    else {
                        App.Instance.listboxRefresh(listBox1, konyvek);
                    }
                }
            }
        }

        private async void btn_Delete_Click(object sender, EventArgs e) {
            int idx = listBox1.SelectedIndex;
            if (idx == -1) lb_Message.Text = "Nincs kiválasztva egy könyv sem!";
            else {
                Konyv k = konyvek[idx];
                int id = k.id;
                using (var client = new HttpClient()) {
                    var response = await client.DeleteAsync(new Uri($"http://localhost:5000/api/Konyv/{id}"));
                    if (response.IsSuccessStatusCode) {
                        lb_Message.Text = "Sikeres törlés!";
                        konyvek.Remove(k);
                        App.Instance.listboxRefresh(listBox1, konyvek);
                    }
                }
            }
        }
    }
}