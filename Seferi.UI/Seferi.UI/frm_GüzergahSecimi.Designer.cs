namespace Seferi.UI
{
    partial class frm_GüzergahSecimi
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
            this.cmb_Nereden = new System.Windows.Forms.ComboBox();
            this.cmb_Nereye = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Sefer = new System.Windows.Forms.DataGridView();
            this.btn_RezervasyonEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sefer)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Nereden
            // 
            this.cmb_Nereden.FormattingEnabled = true;
            this.cmb_Nereden.Location = new System.Drawing.Point(79, 51);
            this.cmb_Nereden.Name = "cmb_Nereden";
            this.cmb_Nereden.Size = new System.Drawing.Size(160, 21);
            this.cmb_Nereden.TabIndex = 0;
            this.cmb_Nereden.SelectedIndexChanged += new System.EventHandler(this.cmb_Nereden_SelectedIndexChanged);
            // 
            // cmb_Nereye
            // 
            this.cmb_Nereye.FormattingEnabled = true;
            this.cmb_Nereye.Location = new System.Drawing.Point(338, 50);
            this.cmb_Nereye.Name = "cmb_Nereye";
            this.cmb_Nereye.Size = new System.Drawing.Size(160, 21);
            this.cmb_Nereye.TabIndex = 0;
            this.cmb_Nereye.SelectedIndexChanged += new System.EventHandler(this.cmb_Nereye_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nereden :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nereye :";
            // 
            // dgv_Sefer
            // 
            this.dgv_Sefer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sefer.Location = new System.Drawing.Point(22, 130);
            this.dgv_Sefer.Name = "dgv_Sefer";
            this.dgv_Sefer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Sefer.Size = new System.Drawing.Size(476, 201);
            this.dgv_Sefer.TabIndex = 2;
            // 
            // btn_RezervasyonEkle
            // 
            this.btn_RezervasyonEkle.Location = new System.Drawing.Point(163, 356);
            this.btn_RezervasyonEkle.Name = "btn_RezervasyonEkle";
            this.btn_RezervasyonEkle.Size = new System.Drawing.Size(224, 23);
            this.btn_RezervasyonEkle.TabIndex = 3;
            this.btn_RezervasyonEkle.Text = "Rezervasyon Ekle";
            this.btn_RezervasyonEkle.UseVisualStyleBackColor = true;
            this.btn_RezervasyonEkle.Click += new System.EventHandler(this.btn_RezervasyonEkle_Click);
            // 
            // frm_GüzergahSecimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 419);
            this.Controls.Add(this.btn_RezervasyonEkle);
            this.Controls.Add(this.dgv_Sefer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Nereye);
            this.Controls.Add(this.cmb_Nereden);
            this.Name = "frm_GüzergahSecimi";
            this.Text = "frm_GüzergahSecimi";
            this.Load += new System.EventHandler(this.frm_GüzergahSecimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sefer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Nereden;
        private System.Windows.Forms.ComboBox cmb_Nereye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Sefer;
        private System.Windows.Forms.Button btn_RezervasyonEkle;
    }
}