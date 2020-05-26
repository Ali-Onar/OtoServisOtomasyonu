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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int secilen;

        void liste()
        {
            var degerler = from x in db.TBLCARI
                           select new
                           {
                               x.ID,
                               x.AD,
                               x.SOYAD,
                               x.MAIL,
                               x.TELEFON,
                               x.IL,
                               x.ILCE
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {

            liste();
            labelControl8.Text = db.TBLCARI.Count().ToString();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLILLER
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir
                                                 }).ToList();

            lookUpEdit2.Properties.DataSource = (from x in db.TBLILCELER
                                                 select new
                                                 {
                                                     x.id,
                                                     x.ilce
                                                 }).ToList();
            labelControl18.Text = db.TBLCARI.Select(x => x.IL).Distinct().Count().ToString();
            labelControl16.Text = db.TBLCARI.Select(x => x.ILCE).Distinct().Count().ToString();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEdit1.EditValue.ToString());
            lookUpEdit2.Properties.DataSource = (from y in db.TBLILCELER
                                                 select new
                                                 {
                                                     y.id,
                                                     y.ilce,
                                                     y.sehir
                                                 }).Where(z => z.sehir == secilen).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text != "" & TxtSoyad.Text != "" & TxtAd.Text.Length <= 20)
            {
                TBLCARI t = new TBLCARI();
                t.AD = TxtAd.Text;
                t.SOYAD = TxtSoyad.Text;
                t.TELEFON = TxtTelefon.Text;
                t.IL = lookUpEdit1.Text;
                t.ILCE = lookUpEdit1.Text;
                db.TBLCARI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Cari Sisteme Eklendi");
                liste();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yeniden deneyin");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
                TxtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
                lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
                lookUpEdit2.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
            


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
