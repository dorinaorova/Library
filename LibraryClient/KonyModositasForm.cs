using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace LibraryClient {
    public partial class KonyModositasForm : Form {
        private Konyv activeKonyv;
        private bool changed;
        public KonyModositasForm(Konyv k) {
            activeKonyv = k;
            InitializeComponent();
            tb_Cim.Text = activeKonyv.cim;
            tb_Szerzo.Text = activeKonyv.iro;
            cb_Kolcs.Checked = activeKonyv.kolcsonozve;
            changed= activeKonyv.kolcsonozve;
        }

        private async void btn_OK_Click(object sender, EventArgs e) {
            activeKonyv.cim = tb_Cim.Text;
            activeKonyv.iro = tb_Szerzo.Text;
            activeKonyv.kolcsonozve = cb_Kolcs.Checked;
            using (var client = new HttpClient()) {
                int id = activeKonyv.id;
                var json = JsonConvert.SerializeObject(activeKonyv);
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                var response = await client.PutAsync(new Uri($"http://localhost:5000/api/Konyv/{id}"), stringContent);

                if (activeKonyv.kolcsonozve != changed && changed ) {
                    response = await client.DeleteAsync(new Uri($"http://localhost:5000/api/Kolcsonzes/{activeKonyv.kolcsonzesId}"));
                }
            }
            this.Close();
        }


    }
}
