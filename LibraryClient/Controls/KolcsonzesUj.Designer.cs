
namespace LibraryClient.Controls {
    partial class KolcsonzesUj {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lb_Date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Nev = new System.Windows.Forms.TextBox();
            this.tb_Szerzo = new System.Windows.Forms.TextBox();
            this.tb_Cim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbox_Konyv = new System.Windows.Forms.ListBox();
            this.lbox_Olvaso = new System.Windows.Forms.ListBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_KeresKonyv = new System.Windows.Forms.Button();
            this.btn_KeresOlvaso = new System.Windows.Forms.Button();
            this.lb_Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új kölcsönzés adatainak felvétele";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Könyv adatai:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(84, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cím:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(60, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Szerző:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(41, 315);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(213, 22);
            this.dateTimePicker.TabIndex = 4;
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Date.Location = new System.Drawing.Point(22, 292);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(70, 20);
            this.lb_Date.TabIndex = 5;
            this.lb_Date.Text = "Dátum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(23, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Olvasó adatai:";
            // 
            // tb_Nev
            // 
            this.tb_Nev.Location = new System.Drawing.Point(129, 233);
            this.tb_Nev.Name = "tb_Nev";
            this.tb_Nev.Size = new System.Drawing.Size(203, 22);
            this.tb_Nev.TabIndex = 7;
            // 
            // tb_Szerzo
            // 
            this.tb_Szerzo.Location = new System.Drawing.Point(129, 139);
            this.tb_Szerzo.Name = "tb_Szerzo";
            this.tb_Szerzo.Size = new System.Drawing.Size(203, 22);
            this.tb_Szerzo.TabIndex = 8;
            // 
            // tb_Cim
            // 
            this.tb_Cim.Location = new System.Drawing.Point(129, 103);
            this.tb_Cim.Name = "tb_Cim";
            this.tb_Cim.Size = new System.Drawing.Size(203, 22);
            this.tb_Cim.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(82, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Név:";
            // 
            // lbox_Konyv
            // 
            this.lbox_Konyv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbox_Konyv.FormattingEnabled = true;
            this.lbox_Konyv.ItemHeight = 16;
            this.lbox_Konyv.Location = new System.Drawing.Point(399, 77);
            this.lbox_Konyv.Name = "lbox_Konyv";
            this.lbox_Konyv.Size = new System.Drawing.Size(263, 84);
            this.lbox_Konyv.TabIndex = 13;
            // 
            // lbox_Olvaso
            // 
            this.lbox_Olvaso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbox_Olvaso.FormattingEnabled = true;
            this.lbox_Olvaso.ItemHeight = 16;
            this.lbox_Olvaso.Location = new System.Drawing.Point(399, 204);
            this.lbox_Olvaso.Name = "lbox_Olvaso";
            this.lbox_Olvaso.Size = new System.Drawing.Size(263, 84);
            this.lbox_Olvaso.TabIndex = 14;
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.Location = new System.Drawing.Point(600, 337);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(62, 30);
            this.btn_OK.TabIndex = 15;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_KeresKonyv
            // 
            this.btn_KeresKonyv.Location = new System.Drawing.Point(172, 167);
            this.btn_KeresKonyv.Name = "btn_KeresKonyv";
            this.btn_KeresKonyv.Size = new System.Drawing.Size(104, 23);
            this.btn_KeresKonyv.TabIndex = 16;
            this.btn_KeresKonyv.Text = "Keresés";
            this.btn_KeresKonyv.UseVisualStyleBackColor = true;
            this.btn_KeresKonyv.Click += new System.EventHandler(this.btn_KeresKonyv_Click);
            // 
            // btn_KeresOlvaso
            // 
            this.btn_KeresOlvaso.Location = new System.Drawing.Point(172, 265);
            this.btn_KeresOlvaso.Name = "btn_KeresOlvaso";
            this.btn_KeresOlvaso.Size = new System.Drawing.Size(104, 23);
            this.btn_KeresOlvaso.TabIndex = 17;
            this.btn_KeresOlvaso.Text = "Keresés";
            this.btn_KeresOlvaso.UseVisualStyleBackColor = true;
            this.btn_KeresOlvaso.Click += new System.EventHandler(this.btn_KeresOlvaso_Click);
            // 
            // lb_Message
            // 
            this.lb_Message.AutoSize = true;
            this.lb_Message.ForeColor = System.Drawing.Color.Red;
            this.lb_Message.Location = new System.Drawing.Point(298, 344);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(0, 17);
            this.lb_Message.TabIndex = 18;
            // 
            // KolcsonzesUj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_Message);
            this.Controls.Add(this.btn_KeresOlvaso);
            this.Controls.Add(this.btn_KeresKonyv);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbox_Olvaso);
            this.Controls.Add(this.lbox_Konyv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Cim);
            this.Controls.Add(this.tb_Szerzo);
            this.Controls.Add(this.tb_Nev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_Date);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KolcsonzesUj";
            this.Size = new System.Drawing.Size(677, 386);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Nev;
        private System.Windows.Forms.TextBox tb_Szerzo;
        private System.Windows.Forms.TextBox tb_Cim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbox_Konyv;
        private System.Windows.Forms.ListBox lbox_Olvaso;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_KeresKonyv;
        private System.Windows.Forms.Button btn_KeresOlvaso;
        private System.Windows.Forms.Label lb_Message;
    }
}
