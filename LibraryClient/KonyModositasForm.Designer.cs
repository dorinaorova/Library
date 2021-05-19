
namespace LibraryClient {
    partial class KonyModositasForm {
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
            this.tb_Cim = new System.Windows.Forms.TextBox();
            this.tb_Szerzo = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Kolcs = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Könyv adatainak módosítása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cím:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Szerző:";
            // 
            // tb_Cim
            // 
            this.tb_Cim.Location = new System.Drawing.Point(37, 76);
            this.tb_Cim.Name = "tb_Cim";
            this.tb_Cim.Size = new System.Drawing.Size(238, 22);
            this.tb_Cim.TabIndex = 3;
            // 
            // tb_Szerzo
            // 
            this.tb_Szerzo.Location = new System.Drawing.Point(37, 127);
            this.tb_Szerzo.Name = "tb_Szerzo";
            this.tb_Szerzo.Size = new System.Drawing.Size(238, 22);
            this.tb_Szerzo.TabIndex = 4;
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_OK.Location = new System.Drawing.Point(154, 216);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(70, 35);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(25, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ki van kölcsönözve?";
            // 
            // cb_Kolcs
            // 
            this.cb_Kolcs.AutoSize = true;
            this.cb_Kolcs.Location = new System.Drawing.Point(202, 163);
            this.cb_Kolcs.Name = "cb_Kolcs";
            this.cb_Kolcs.Size = new System.Drawing.Size(18, 17);
            this.cb_Kolcs.TabIndex = 7;
            this.cb_Kolcs.UseVisualStyleBackColor = true;
            // 
            // KonyModositasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 263);
            this.Controls.Add(this.cb_Kolcs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tb_Szerzo);
            this.Controls.Add(this.tb_Cim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KonyModositasForm";
            this.Text = "Könyv adatainak módosítása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Cim;
        private System.Windows.Forms.TextBox tb_Szerzo;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_Kolcs;
    }
}