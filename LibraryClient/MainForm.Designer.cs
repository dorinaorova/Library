
namespace LibraryClient {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.könyvekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újKönyvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.olvasókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.újOlvasóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kölcsönzésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újKölcsönzésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.könyvekToolStripMenuItem,
            this.olvasókToolStripMenuItem,
            this.kölcsönzésekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // könyvekToolStripMenuItem
            // 
            this.könyvekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keresésToolStripMenuItem,
            this.újKönyvToolStripMenuItem});
            this.könyvekToolStripMenuItem.Name = "könyvekToolStripMenuItem";
            this.könyvekToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.könyvekToolStripMenuItem.Text = "Könyvek";
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.Click += new System.EventHandler(this.keresésToolStripMenuItem_Click);
            // 
            // újKönyvToolStripMenuItem
            // 
            this.újKönyvToolStripMenuItem.Name = "újKönyvToolStripMenuItem";
            this.újKönyvToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.újKönyvToolStripMenuItem.Text = "Új könyv";
            this.újKönyvToolStripMenuItem.Click += new System.EventHandler(this.újKönyvToolStripMenuItem_Click);
            // 
            // olvasókToolStripMenuItem
            // 
            this.olvasókToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keresésToolStripMenuItem1,
            this.újOlvasóToolStripMenuItem});
            this.olvasókToolStripMenuItem.Name = "olvasókToolStripMenuItem";
            this.olvasókToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.olvasókToolStripMenuItem.Text = "Olvasók";
            // 
            // keresésToolStripMenuItem1
            // 
            this.keresésToolStripMenuItem1.Name = "keresésToolStripMenuItem1";
            this.keresésToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.keresésToolStripMenuItem1.Text = "Keresés";
            this.keresésToolStripMenuItem1.Click += new System.EventHandler(this.keresésToolStripMenuItem1_Click);
            // 
            // újOlvasóToolStripMenuItem
            // 
            this.újOlvasóToolStripMenuItem.Name = "újOlvasóToolStripMenuItem";
            this.újOlvasóToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.újOlvasóToolStripMenuItem.Text = "Új olvasó";
            this.újOlvasóToolStripMenuItem.Click += new System.EventHandler(this.újOlvasóToolStripMenuItem_Click);
            // 
            // kölcsönzésekToolStripMenuItem
            // 
            this.kölcsönzésekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újKölcsönzésToolStripMenuItem});
            this.kölcsönzésekToolStripMenuItem.Name = "kölcsönzésekToolStripMenuItem";
            this.kölcsönzésekToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.kölcsönzésekToolStripMenuItem.Text = "Kölcsönzések";
            // 
            // újKölcsönzésToolStripMenuItem
            // 
            this.újKölcsönzésToolStripMenuItem.Name = "újKölcsönzésToolStripMenuItem";
            this.újKölcsönzésToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.újKölcsönzésToolStripMenuItem.Text = "Új kölcsönzés";
            this.újKölcsönzésToolStripMenuItem.Click += new System.EventHandler(this.újKölcsönzésToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(732, 415);
            this.panel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 443);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Könyvtári nyilvántartás";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem könyvekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újKönyvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem olvasókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem újOlvasóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kölcsönzésekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újKölcsönzésToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
    }
}

