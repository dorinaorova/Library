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
    public partial class OlvasoUj : UserControl {
        public OlvasoUj() {
            InitializeComponent();
        }

        private async void btn_OK_Click(object sender, EventArgs e) {
            Olvaso uj = new Olvaso();
            uj.Nev = tb_Nev.Text;
            uj.Szul = dtp_Szul.Value;

            using (var client = new HttpClient()) {
                var json = JsonConvert.SerializeObject(uj);
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                var response = await client.PostAsync(new Uri($"http://localhost:5000/api/Olvaso"), stringContent);
                if (response.IsSuccessStatusCode) {
                    lb_Message.Text = $"A következő olvasó került az adatbázisba: {uj.ToString()}";
                }
            }
        }
    }
}
