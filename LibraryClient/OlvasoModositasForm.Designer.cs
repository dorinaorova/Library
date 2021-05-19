
namespace LibraryClient {
    partial class OlvasoModositasForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Vissza = new System.Windows.Forms.Button();
            this.tb_Nev = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.dtp_Szul = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Olvasó adatainak módosítása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(14, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Születési idő:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(358, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kölcsönzések:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(361, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(424, 212);
            this.listBox1.TabIndex = 4;
            // 
            // btn_Vissza
            // 
            this.btn_Vissza.Location = new System.Drawing.Point(527, 300);
            this.btn_Vissza.Name = "btn_Vissza";
            this.btn_Vissza.Size = new System.Drawing.Size(102, 40);
            this.btn_Vissza.TabIndex = 5;
            this.btn_Vissza.Text = "Visszahozta";
            this.btn_Vissza.UseVisualStyleBackColor = true;
            this.btn_Vissza.Click += new System.EventHandler(this.btn_Vissza_Click);
            // 
            // tb_Nev
            // 
            this.tb_Nev.Location = new System.Drawing.Point(17, 82);
            this.tb_Nev.Name = "tb_Nev";
            this.tb_Nev.Size = new System.Drawing.Size(248, 22);
            this.tb_Nev.TabIndex = 6;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(317, 401);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 37);
            this.btn_OK.TabIndex = 8;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // dtp_Szul
            // 
            this.dtp_Szul.Location = new System.Drawing.Point(20, 153);
            this.dtp_Szul.Name = "dtp_Szul";
            this.dtp_Szul.Size = new System.Drawing.Size(244, 22);
            this.dtp_Szul.TabIndex = 9;
            // 
            // OlvasoModositasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp_Szul);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tb_Nev);
            this.Controls.Add(this.btn_Vissza);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OlvasoModositasForm";
            this.Text = "Olvasó adatainak módosítása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Vissza;
        private System.Windows.Forms.TextBox tb_Nev;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DateTimePicker dtp_Szul;
    }
}