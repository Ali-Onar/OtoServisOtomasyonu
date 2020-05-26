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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            var degerler = from k in db.TBLKATEGORI
                           select new
                           {
                               k.ID,
                               k.AD
                           };

            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text != "" && TxtAd.Text.Length <= 30)
            {
                TBLKATEGORI t = new TBLKATEGORI();
                t.AD = TxtAd.Text;
                db.TBLKATEGORI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori başarıyla kaydedildi!");
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Bırakılamaz veya Kategori Adı 30 Karakterden Uzun Olamaz!");
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from k in db.TBLKATEGORI
                           select new
                           {
                               k.ID,
                               k.AD
                           };

            gridControl1.DataSource = degerler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLKATEGORI.Find(id);
            db.TBLKATEGORI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLKATEGORI.Find(id);
            deger.AD = TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Text = "";
            TxtID.Text = "";
        }
    }
}
