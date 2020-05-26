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
    public partial class FrmArizaliAracListesi : Form
    {
        public FrmArizaliAracListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void metot2()
        {
            var degerler = from u in db.TBLARACARIZA
                           select new
                           {
                               u.ID,
                               u.PLAKA,
                               u.MUSTERIAD,
                               u.MUSTERISOYAD,
                               u.PERSONELAD,
                               u.PERSONELSOYAD, 
                               u.GIRISTARIHI,
                               u.CIKISTARIHI,
                               u.ONFIYAT,
                               u.NETFIYAT,
                               u.ARIZADETAY
                           };

            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmArizaliAracListesi_Load(object sender, EventArgs e)
        {
            metot2();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            // t.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());

            TBLARACARIZA t = new TBLARACARIZA();
            t.PLAKA = TxtAracPlaka.Text;
            t.MUSTERIAD = TxtMusAd.Text;
            t.MUSTERISOYAD = TxtMusSoyad.Text;
            t.PERSONELAD = TxtPerAd.Text;
            t.PERSONELSOYAD = TxtPerSoyad.Text;
            t.GIRISTARIHI = DateTime.Parse(TxtGirisTarihi.Text);
            t.CIKISTARIHI = DateTime.Parse(TxtCikisTarihi.Text);
            t.ONFIYAT = decimal.Parse(TxtOnFiyat.Text);
            t.NETFIYAT = decimal.Parse(TxtNetFiyat.Text);
            t.ARIZADETAY = richTextBox1.Text;

            db.TBLARACARIZA.Add(t);
            db.SaveChanges();
            MessageBox.Show("Araç başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLARACARIZA.Find(id);
            db.TBLARACARIZA.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Araç Kaydı başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLARACARIZA.Find(id);
            deger.PLAKA = TxtAracPlaka.Text;
            deger.MUSTERIAD = TxtMusAd.Text;
            deger.MUSTERISOYAD = TxtMusSoyad.Text;
            deger.PERSONELAD = TxtPerAd.Text;
            deger.PERSONELSOYAD = TxtPerSoyad.Text;
            deger.GIRISTARIHI = DateTime.Parse(TxtGirisTarihi.Text);
            deger.CIKISTARIHI = DateTime.Parse(TxtCikisTarihi.Text);
            deger.ONFIYAT = decimal.Parse(TxtOnFiyat.Text);
            deger.NETFIYAT = decimal.Parse(TxtOnFiyat.Text);
            deger.ARIZADETAY = richTextBox1.Text;
            db.SaveChanges();
            MessageBox.Show("Araç Bilgileri Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            metot2();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAracPlaka.Text = "";
            TxtMusAd.Text = "";
            TxtMusSoyad.Text = "";
            TxtPerAd.Text = "";
            TxtPerSoyad.Text = "";
            TxtGirisTarihi.Text = "";
            TxtCikisTarihi.Text = "";
            TxtOnFiyat.Text = "";
            TxtNetFiyat.Text = "";
            richTextBox1.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                TxtAracPlaka.Text = gridView1.GetFocusedRowCellValue("PLAKA").ToString();
                TxtMusAd.Text = gridView1.GetFocusedRowCellValue("MUSTERIAD").ToString();
                TxtMusSoyad.Text = gridView1.GetFocusedRowCellValue("MUSTERISOYAD").ToString();
                TxtPerAd.Text = gridView1.GetFocusedRowCellValue("PERSONELAD").ToString();
                TxtPerSoyad.Text = gridView1.GetFocusedRowCellValue("PERSONELSOYAD").ToString();
                TxtGirisTarihi.Text = gridView1.GetFocusedRowCellValue("GIRISTARIHI").ToString();
                TxtCikisTarihi.Text = gridView1.GetFocusedRowCellValue("CIKISTARIHI").ToString();
                TxtOnFiyat.Text = gridView1.GetFocusedRowCellValue("ONFIYAT").ToString();
                TxtNetFiyat.Text = gridView1.GetFocusedRowCellValue("NETFIYAT").ToString();
                richTextBox1.Text = gridView1.GetFocusedRowCellValue("ARIZADETAY").ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
        }
    }
}
