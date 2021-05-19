
namespace LibraryClient.Controls {
    partial class OlvasoKereses {
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lb_Message = new System.Windows.Forms.Label();
            this.btn_Keres = new System.Windows.Forms.Button();
            this.tb_Nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Ossz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Ossz);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Message);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Keres);
            this.splitContainer1.Panel1.Controls.Add(this.tb_Nev);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBox);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Update);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Delete);
            this.splitContainer1.Size = new System.Drawing.Size(729, 424);
            this.splitContainer1.SplitterDistance = 319;
            this.splitContainer1.TabIndex = 0;
            // 
            // lb_Message
            // 
            this.lb_Message.AutoSize = true;
            this.lb_Message.ForeColor = System.Drawing.Color.Red;
            this.lb_Message.Location = new System.Drawing.Point(33, 370);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(0, 17);
            this.lb_Message.TabIndex = 4;
            // 
            // btn_Keres
            // 
            this.btn_Keres.Location = new System.Drawing.Point(117, 140);
            this.btn_Keres.Name = "btn_Keres";
            this.btn_Keres.Size = new System.Drawing.Size(75, 23);
            this.btn_Keres.TabIndex = 3;
            this.btn_Keres.Text = "Keresés";
            this.btn_Keres.UseVisualStyleBackColor = true;
            this.btn_Keres.Click += new System.EventHandler(this.btn_Keres_Click);
            // 
            // tb_Nev
            // 
            this.tb_Nev.Location = new System.Drawing.Point(46, 85);
            this.tb_Nev.Name = "tb_Nev";
            this.tb_Nev.Size = new System.Drawing.Size(243, 22);
            this.tb_Nev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Olvasó keresése";
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(406, 356);
            this.listBox.TabIndex = 2;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(284, 370);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(91, 31);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Módosítás";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(42, 370);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(89, 31);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.Text = "Törlés";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Ossz
            // 
            this.btn_Ossz.Location = new System.Drawing.Point(66, 169);
            this.btn_Ossz.Name = "btn_Ossz";
            this.btn_Ossz.Size = new System.Drawing.Size(168, 36);
            this.btn_Ossz.TabIndex = 5;
            this.btn_Ossz.Text = "Összes olvasó listázása";
            this.btn_Ossz.UseVisualStyleBackColor = true;
            this.btn_Ossz.Click += new System.EventHandler(this.btn_Ossz_Click);
            // 
            // OlvasoKereses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "OlvasoKereses";
            this.Size = new System.Drawing.Size(729, 424);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Keres;
        private System.Windows.Forms.TextBox tb_Nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lb_Message;
        private System.Windows.Forms.Button btn_Ossz;
    }
}
