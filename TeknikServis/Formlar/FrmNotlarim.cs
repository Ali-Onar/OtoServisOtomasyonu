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
    public partial class FrmNotlarim : Form
    {
        public FrmNotlarim()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        void metot3()
        {
            var degerler = from u in db.TBLNOTLARIM
                           select new
                           {
                               u.ID,
                               u.BASLIK,
                               u.ICERIK,
                               u.TARIH
                           };

            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmNotlarim_Load(object sender, EventArgs e)
        {
            metot3();
        
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLARIM t = new TBLNOTLARIM();
            t.BASLIK = TxtBaslik.Text;
            t.ICERIK = TxtIcerik.Text;
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            db.TBLNOTLARIM.Add(t);
            db.SaveChanges();
            MessageBox.Show("Notunuz başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLNOTLARIM.Find(id);
            db.TBLNOTLARIM.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kaydedilen not başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLNOTLARIM.Find(id);
            deger.BASLIK = TxtBaslik.Text;
            deger.ICERIK = TxtIcerik.Text;
            deger.TARIH = DateTime.Parse(TxtTarih.Text);
            db.SaveChanges();
            MessageBox.Show("Notunuz başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            metot3();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtBaslik.Text = "";
            TxtIcerik.Text = "";
            TxtTarih.Text = "";
        }
    }
}
