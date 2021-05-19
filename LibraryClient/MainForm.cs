using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryClient {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }
        public Panel Panel{ get { return panel; } }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e) {
            App.Instance.KonyvKeres();
        }

        private void újKönyvToolStripMenuItem_Click(object sender, EventArgs e) {
            App.Instance.KonyvUj();
        }

        private void újKölcsönzésToolStripMenuItem_Click(object sender, EventArgs e) {
            App.Instance.Kolcsonzes();
        }

        private void keresésToolStripMenuItem1_Click(object sender, EventArgs e) {
            App.Instance.OlvasoKeres();
        }

        private void újOlvasóToolStripMenuItem_Click(object sender, EventArgs e) {
            App.Instance.OlvasoUj();
        }
    }
}
