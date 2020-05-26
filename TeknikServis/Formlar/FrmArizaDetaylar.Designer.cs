namespace TeknikServis.Formlar
{
    partial class FrmArizaDetaylar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArizaDetaylar));
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TxtTarih = new DevExpress.XtraEditors.TextEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnVazgec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(22, 447);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(177, 40);
            this.BtnGuncelle.TabIndex = 5;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(35, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(343, 31);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "ARIZALI ÜRÜN KAYDI AÇIKLAMA";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(24, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(366, 3);
            this.panel4.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(24, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 3);
            this.panel1.TabIndex = 51;
            // 
            // TxtSeriNo
            // 
            this.TxtSeriNo.EditValue = "Seri No";
            this.TxtSeriNo.Location = new System.Drawing.Point(24, 98);
            this.TxtSeriNo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSeriNo.Name = "TxtSeriNo";
            this.TxtSeriNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtSeriNo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSeriNo.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtSeriNo.Properties.Appearance.Options.UseBackColor = true;
            this.TxtSeriNo.Properties.Appearance.Options.UseFont = true;
            this.TxtSeriNo.Properties.Appearance.Options.UseForeColor = true;
            this.TxtSeriNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtSeriNo.Properties.Mask.EditMask = "d";
            this.TxtSeriNo.Size = new System.Drawing.Size(366, 32);
            this.TxtSeriNo.TabIndex = 1;
            this.TxtSeriNo.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            this.TxtSeriNo.Click += new System.EventHandler(this.textEdit1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(22, 328);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(372, 96);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Arıza Detayları";
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            // 
            // TxtTarih
            // 
            this.TxtTarih.EditValue = "Tarih";
            this.TxtTarih.Location = new System.Drawing.Point(24, 165);
            this.TxtTarih.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtTarih.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTarih.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtTarih.Properties.Appearance.Options.UseBackColor = true;
            this.TxtTarih.Properties.Appearance.Options.UseFont = true;
            this.TxtTarih.Properties.Appearance.Options.UseForeColor = true;
            this.TxtTarih.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtTarih.Properties.Mask.EditMask = "d";
            this.TxtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.TxtTarih.Size = new System.Drawing.Size(366, 32);
            this.TxtTarih.TabIndex = 2;
            this.TxtTarih.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            this.TxtTarih.Click += new System.EventHandler(this.textEdit2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ürün Kaydoldu",
            "Parça Bekliyor",
            "Mesaj Bekliyor",
            "İptal Edildi",
            "Fiyat Verildi"});
            this.comboBox1.Location = new System.Drawing.Point(22, 247);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(372, 36);
            this.comboBox1.TabIndex = 3;
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnVazgec.ImageOptions.Image")));
            this.BtnVazgec.Location = new System.Drawing.Point(216, 447);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(174, 40);
            this.BtnVazgec.TabIndex = 57;
            this.BtnVazgec.Text = "Vazgeç";
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // FrmArizaDetaylar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(418, 518);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TxtTarih);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtSeriNo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnGuncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArizaDetaylar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArizaDetaylar";
            this.Load += new System.EventHandler(this.FrmArizaDetaylar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit TxtSeriNo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.TextEdit TxtTarih;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.SimpleButton BtnVazgec;
    }
}