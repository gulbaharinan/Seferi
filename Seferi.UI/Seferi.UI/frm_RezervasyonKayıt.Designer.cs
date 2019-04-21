namespace Seferi.UI
{
    partial class frm_RezervasyonKayıt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.txt_TCKN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxt_Aciklama = new System.Windows.Forms.RichTextBox();
            this.btn_RezervasyonKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri T.C :";
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(143, 37);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(180, 20);
            this.txt_AdSoyad.TabIndex = 1;
            // 
            // txt_TCKN
            // 
            this.txt_TCKN.Location = new System.Drawing.Point(143, 71);
            this.txt_TCKN.Name = "txt_TCKN";
            this.txt_TCKN.Size = new System.Drawing.Size(180, 20);
            this.txt_TCKN.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Açıklama :";
            // 
            // rtxt_Aciklama
            // 
            this.rtxt_Aciklama.Location = new System.Drawing.Point(143, 108);
            this.rtxt_Aciklama.Name = "rtxt_Aciklama";
            this.rtxt_Aciklama.Size = new System.Drawing.Size(180, 96);
            this.rtxt_Aciklama.TabIndex = 2;
            this.rtxt_Aciklama.Text = "";
            // 
            // btn_RezervasyonKaydet
            // 
            this.btn_RezervasyonKaydet.Location = new System.Drawing.Point(102, 228);
            this.btn_RezervasyonKaydet.Name = "btn_RezervasyonKaydet";
            this.btn_RezervasyonKaydet.Size = new System.Drawing.Size(154, 38);
            this.btn_RezervasyonKaydet.TabIndex = 3;
            this.btn_RezervasyonKaydet.Text = "Rezervasyon Kaydet";
            this.btn_RezervasyonKaydet.UseVisualStyleBackColor = true;
            this.btn_RezervasyonKaydet.Click += new System.EventHandler(this.btn_RezervasyonKaydet_Click);
            // 
            // frm_RezervasyonKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 289);
            this.Controls.Add(this.btn_RezervasyonKaydet);
            this.Controls.Add(this.rtxt_Aciklama);
            this.Controls.Add(this.txt_TCKN);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_RezervasyonKayıt";
            this.Text = "frm_RezervasyonKayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.TextBox txt_TCKN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxt_Aciklama;
        private System.Windows.Forms.Button btn_RezervasyonKaydet;
    }
}