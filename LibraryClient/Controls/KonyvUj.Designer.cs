
namespace LibraryClient.Controls {
    partial class KonyvUj {
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
            this.lb_Cim = new System.Windows.Forms.Label();
            this.lb_Szerzo = new System.Windows.Forms.Label();
            this.tb_Cim = new System.Windows.Forms.TextBox();
            this.tb_Szerzo = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.lb_Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új könyv felvétele";
            // 
            // lb_Cim
            // 
            this.lb_Cim.AutoSize = true;
            this.lb_Cim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Cim.Location = new System.Drawing.Point(33, 87);
            this.lb_Cim.Name = "lb_Cim";
            this.lb_Cim.Size = new System.Drawing.Size(39, 17);
            this.lb_Cim.TabIndex = 1;
            this.lb_Cim.Text = "Cím:";
            // 
            // lb_Szerzo
            // 
            this.lb_Szerzo.AutoSize = true;
            this.lb_Szerzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Szerzo.Location = new System.Drawing.Point(33, 162);
            this.lb_Szerzo.Name = "lb_Szerzo";
            this.lb_Szerzo.Size = new System.Drawing.Size(63, 17);
            this.lb_Szerzo.TabIndex = 2;
            this.lb_Szerzo.Text = "Szerző:";
            // 
            // tb_Cim
            // 
            this.tb_Cim.Location = new System.Drawing.Point(36, 107);
            this.tb_Cim.Name = "tb_Cim";
            this.tb_Cim.Size = new System.Drawing.Size(217, 22);
            this.tb_Cim.TabIndex = 3;
            // 
            // tb_Szerzo
            // 
            this.tb_Szerzo.Location = new System.Drawing.Point(36, 182);
            this.tb_Szerzo.Name = "tb_Szerzo";
            this.tb_Szerzo.Size = new System.Drawing.Size(217, 22);
            this.tb_Szerzo.TabIndex = 4;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(118, 238);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(50, 30);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lb_Message
            // 
            this.lb_Message.AutoSize = true;
            this.lb_Message.ForeColor = System.Drawing.Color.Red;
            this.lb_Message.Location = new System.Drawing.Point(33, 308);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(0, 17);
            this.lb_Message.TabIndex = 6;
            // 
            // KonyvUj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_Message);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tb_Szerzo);
            this.Controls.Add(this.tb_Cim);
            this.Controls.Add(this.lb_Szerzo);
            this.Controls.Add(this.lb_Cim);
            this.Controls.Add(this.label1);
            this.Name = "KonyvUj";
            this.Size = new System.Drawing.Size(289, 353);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Cim;
        private System.Windows.Forms.Label lb_Szerzo;
        private System.Windows.Forms.TextBox tb_Cim;
        private System.Windows.Forms.TextBox tb_Szerzo;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lb_Message;
    }
}
