using LibraryClient.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryClient {
    public class App {
        private MainForm mainForm;
        private static App theApp;
        public static App Instance { get { return theApp; } }
        public static void Initialize(MainForm form) {
            theApp = new App();
            theApp.mainForm = form;
        }

        public void KonyvModositas(Konyv k) {
            KonyModositasForm kmform = new KonyModositasForm(k);
            kmform.ShowDialog();
        }

        public void KonyvKeres() {
            mainForm.Panel.Controls.Clear();
            mainForm.Panel.Controls.Add(new KonyvKeresesControl());
        }

        public void KonyvUj() {
            mainForm.Panel.Controls.Clear();
            mainForm.Panel.Controls.Add(new KonyvUj());
        }

        public void Kolcsonzes() {
            mainForm.Panel.Controls.Clear();
            mainForm.Panel.Controls.Add(new KolcsonzesUj());
        }
        public void OlvasoKeres() {
            mainForm.Panel.Controls.Clear();
            mainForm.Panel.Controls.Add(new OlvasoKereses());
        }
        public void OlvasoUj() {
            mainForm.Panel.Controls.Clear();
            mainForm.Panel.Controls.Add(new OlvasoUj());
        }
        public void OlvasoModositas(Olvaso o) {
            OlvasoModositasForm omform = new OlvasoModositasForm(o);
            omform.ShowDialog();
        }

        public void listboxRefresh(ListBox lbox, IEnumerable<Object> collection) {
            lbox.Items.Clear();
            lbox.BeginUpdate();
            foreach (var item in collection) {
                lbox.Items.Add(item.ToString());
            }
            lbox.EndUpdate();
        }
    }
}
