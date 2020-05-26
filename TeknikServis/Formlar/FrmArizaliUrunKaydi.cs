using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {


            TBLURUNKABUL t = new TBLURUNKABUL();
            t.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
            t.GELISTARIHI = DateTime.Parse(TxtTarih.Text);
            t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
            t.URUNSERINO = TxtSeriNo.Text;
            t.URUNDURUMDETAY = "Ürün Kaydoldu";
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün arıza girişi yapıldı.");
        }

        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            // Müşteri
            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
            // Müşteri
            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
