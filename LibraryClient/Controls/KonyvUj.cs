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
    public partial class KonyvUj : UserControl {
        public KonyvUj() {
            InitializeComponent();
        }

        private async void btn_OK_Click(object sender, EventArgs e) {
            Konyv uj = new Konyv();
            uj.cim = tb_Cim.Text;
            uj.iro = tb_Szerzo.Text;
            uj.kolcsonozve = false;

            using (var client = new HttpClient()) {
                var json = JsonConvert.SerializeObject(uj);
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                var response = await client.PostAsync(new Uri($"http://localhost:5000/api/Konyv"), stringContent);
                if (response.IsSuccessStatusCode) {
                    lb_Message.Text = "Sikeres könyvfelvétel!";
                }
            }
        }
    }
}
