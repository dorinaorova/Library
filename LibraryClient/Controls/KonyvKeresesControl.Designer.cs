
namespace LibraryClient {
    partial class KonyvKeresesControl {
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
            this.btn_Keres = new System.Windows.Forms.Button();
            this.lb_keres = new System.Windows.Forms.Label();
            this.tb_Cim = new System.Windows.Forms.TextBox();
            this.lb_Cim = new System.Windows.Forms.Label();
            this.lb_Szerzo = new System.Windows.Forms.Label();
            this.lb_Kolcs = new System.Windows.Forms.Label();
            this.tb_Iro = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rb_passz = new System.Windows.Forms.RadioButton();
            this.rb_Nem = new System.Windows.Forms.RadioButton();
            this.rb_Igen = new System.Windows.Forms.RadioButton();
            this.lb_Message = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Keres
            // 
            this.btn_Keres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Keres.Location = new System.Drawing.Point(94, 321);
            this.btn_Keres.Name = "btn_Keres";
            this.btn_Keres.Size = new System.Drawing.Size(88, 33);
            this.btn_Keres.TabIndex = 0;
            this.btn_Keres.Text = "Keresés";
            this.btn_Keres.UseVisualStyleBackColor = true;
            this.btn_Keres.Click += new System.EventHandler(this.btn_Keres_ClickAsync);
            // 
            // lb_keres
            // 
            this.lb_keres.AutoSize = true;
            this.lb_keres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_keres.Location = new System.Drawing.Point(22, 28);
            this.lb_keres.Name = "lb_keres";
            this.lb_keres.Size = new System.Drawing.Size(167, 25);
            this.lb_keres.TabIndex = 1;
            this.lb_keres.Text = "Könyv keresése";
            // 
            // tb_Cim
            // 
            this.tb_Cim.Location = new System.Drawing.Point(27, 92);
            this.tb_Cim.Name = "tb_Cim";
            this.tb_Cim.Size = new System.Drawing.Size(228, 22);
            this.tb_Cim.TabIndex = 3;
            // 
            // lb_Cim
            // 
            this.lb_Cim.AutoSize = true;
            this.lb_Cim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Cim.Location = new System.Drawing.Point(26, 72);
            this.lb_Cim.Name = "lb_Cim";
            this.lb_Cim.Size = new System.Drawing.Size(39, 17);
            this.lb_Cim.TabIndex = 4;
            this.lb_Cim.Text = "Cím:";
            // 
            // lb_Szerzo
            // 
            this.lb_Szerzo.AutoSize = true;
            this.lb_Szerzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Szerzo.Location = new System.Drawing.Point(24, 131);
            this.lb_Szerzo.Name = "lb_Szerzo";
            this.lb_Szerzo.Size = new System.Drawing.Size(63, 17);
            this.lb_Szerzo.TabIndex = 5;
            this.lb_Szerzo.Text = "Szerző:";
            // 
            // lb_Kolcs
            // 
            this.lb_Kolcs.AutoSize = true;
            this.lb_Kolcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Kolcs.Location = new System.Drawing.Point(24, 195);
            this.lb_Kolcs.Name = "lb_Kolcs";
            this.lb_Kolcs.Size = new System.Drawing.Size(156, 17);
            this.lb_Kolcs.TabIndex = 6;
            this.lb_Kolcs.Text = "Ki van kölcsönözve?";
            // 
            // tb_Iro
            // 
            this.tb_Iro.Location = new System.Drawing.Point(27, 151);
            this.tb_Iro.Name = "tb_Iro";
            this.tb_Iro.Size = new System.Drawing.Size(226, 22);
            this.tb_Iro.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rb_passz);
            this.splitContainer1.Panel1.Controls.Add(this.rb_Nem);
            this.splitContainer1.Panel1.Controls.Add(this.rb_Igen);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Message);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Keres);
            this.splitContainer1.Panel1.Controls.Add(this.lb_keres);
            this.splitContainer1.Panel1.Controls.Add(this.tb_Cim);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Cim);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Szerzo);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Kolcs);
            this.splitContainer1.Panel1.Controls.Add(this.tb_Iro);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_Update);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Delete);
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Size = new System.Drawing.Size(695, 430);
            this.splitContainer1.SplitterDistance = 317;
            this.splitContainer1.TabIndex = 9;
            // 
            // rb_passz
            // 
            this.rb_passz.AutoSize = true;
            this.rb_passz.Location = new System.Drawing.Point(42, 269);
            this.rb_passz.Name = "rb_passz";
            this.rb_passz.Size = new System.Drawing.Size(91, 21);
            this.rb_passz.TabIndex = 13;
            this.rb_passz.TabStop = true;
            this.rb_passz.Text = "Jó kérdés";
            this.rb_passz.UseVisualStyleBackColor = true;
            // 
            // rb_Nem
            // 
            this.rb_Nem.AutoSize = true;
            this.rb_Nem.Location = new System.Drawing.Point(42, 242);
            this.rb_Nem.Name = "rb_Nem";
            this.rb_Nem.Size = new System.Drawing.Size(58, 21);
            this.rb_Nem.TabIndex = 12;
            this.rb_Nem.TabStop = true;
            this.rb_Nem.Text = "Nem";
            this.rb_Nem.UseVisualStyleBackColor = true;
            // 
            // rb_Igen
            // 
            this.rb_Igen.AutoSize = true;
            this.rb_Igen.Location = new System.Drawing.Point(42, 215);
            this.rb_Igen.Name = "rb_Igen";
            this.rb_Igen.Size = new System.Drawing.Size(56, 21);
            this.rb_Igen.TabIndex = 11;
            this.rb_Igen.TabStop = true;
            this.rb_Igen.Text = "Igen";
            this.rb_Igen.UseVisualStyleBackColor = true;
            // 
            // lb_Message
            // 
            this.lb_Message.AutoSize = true;
            this.lb_Message.ForeColor = System.Drawing.Color.Red;
            this.lb_Message.Location = new System.Drawing.Point(24, 385);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(0, 17);
            this.lb_Message.TabIndex = 10;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.Location = new System.Drawing.Point(240, 361);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(108, 36);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Módosítás";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Delete.Location = new System.Drawing.Point(19, 361);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(108, 36);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Törlés";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(374, 324);
            this.listBox1.TabIndex = 0;
            // 
            // KonyvKeresesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "KonyvKeresesControl";
            this.Size = new System.Drawing.Size(695, 430);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Keres;
        private System.Windows.Forms.Label lb_keres;
        private System.Windows.Forms.TextBox tb_Cim;
        private System.Windows.Forms.Label lb_Cim;
        private System.Windows.Forms.Label lb_Szerzo;
        private System.Windows.Forms.Label lb_Kolcs;
        private System.Windows.Forms.TextBox tb_Iro;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lb_Message;
        private System.Windows.Forms.RadioButton rb_Nem;
        private System.Windows.Forms.RadioButton rb_Igen;
        private System.Windows.Forms.RadioButton rb_passz;
    }
}
