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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void metot1()
        {
            var degerler = from u in db.TBLURUN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               KATEGORI = u.TBLKATEGORI.AD,
                               u.STOK,
                               u.ALISFIYAT,
                               u.SATISFIYAT
                           };

            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
           
            metot1();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.AD = TxtUrunAd.Text;
            t.MARKA = TxtMarka.Text;
            t.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
            t.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
            t.DURUM = false;
            t.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            t.STOK = short.Parse(TxtStok.Text);
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                TxtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                TxtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
                TxtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
                TxtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
                TxtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
                lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("KATEGORI").ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLURUN.Find(id);
            deger.AD = TxtUrunAd.Text;
            deger.MARKA = TxtMarka.Text;
            deger.STOK = short.Parse(TxtStok.Text);
            deger.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
            deger.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
            deger.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAlisFiyat.Text = "";
            TxtID.Text = "";
            TxtMarka.Text="";
            TxtSatisFiyat.Text = "";
            TxtStok.Text = "";
            TxtUrunAd.Text = "";

        }
    }
}
