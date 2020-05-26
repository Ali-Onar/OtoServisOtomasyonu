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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void liste()
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               DEPARTMAN = u.TBLDEPARTMAN.AD,
                               u.MAIL,
                               u.TELEFON
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            liste();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                select new
                                                {
                                                    x.ID,
                                                    x.AD
                                                }).ToList();
            string ad1, soyad1, ad2, soyad2, ad3, soyad3, ad4, soyad4;
            //1. personel
            ad1 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad1 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl9.Text = ad1 + " " + soyad1;
            labelControl8.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl12.Text = db.TBLPERSONEL.First(x => x.ID == 1).TELEFON;

            //2. personel
            ad2 = db.TBLPERSONEL.First(x => x.ID == 2).AD;
            soyad2 = db.TBLPERSONEL.First(x => x.ID == 2).SOYAD;
            labelControl18.Text = ad2 + " " + soyad2;
            labelControl15.Text = db.TBLPERSONEL.First(x => x.ID == 2).TBLDEPARTMAN.AD;
            labelControl14.Text = db.TBLPERSONEL.First(x => x.ID == 2).TELEFON;

            //3. personel
            ad3 = db.TBLPERSONEL.First(x => x.ID == 3).AD;
            soyad3 = db.TBLPERSONEL.First(x => x.ID == 3).SOYAD;
            labelControl30.Text = ad3 + " " + soyad3;
            labelControl27.Text = db.TBLPERSONEL.First(x => x.ID == 3).TBLDEPARTMAN.AD;
            labelControl26.Text = db.TBLPERSONEL.First(x => x.ID == 3).TELEFON;

            //4. personel
            ad4 = db.TBLPERSONEL.First(x => x.ID == 4).AD;
            soyad4 = db.TBLPERSONEL.First(x => x.ID == 4).SOYAD;
            labelControl24.Text = ad4 + " " + soyad4;
            labelControl21.Text = db.TBLPERSONEL.First(x => x.ID == 4).TBLDEPARTMAN.AD;
            labelControl20.Text = db.TBLPERSONEL.First(x => x.ID == 4).TELEFON;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
                TBLPERSONEL t = new TBLPERSONEL();
                t.AD = TxtAd.Text;
                t.SOYAD = TxtSoyad.Text;
                t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
                t.MAIL = TxtMail.Text;
                t.TELEFON = TxtTelefon.Text;

                db.TBLPERSONEL.Add(t);
                db.SaveChanges();
                MessageBox.Show("Personel Sisteme Eklendi");
                liste();
            
            
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLPERSONEL.Find(id);
            db.TBLPERSONEL.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Personel başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLPERSONEL.Find(id);
            deger.AD = TxtAd.Text;
            deger.SOYAD = TxtSoyad.Text;
            deger.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
            deger.MAIL = TxtMail.Text;
            deger.TELEFON = TxtTelefon.Text;
            db.SaveChanges();
            MessageBox.Show("Departman başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
                lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("DEPARTMAN").ToString();
                TxtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
                TxtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtMail.Text = "";
            TxtTelefon.Text = "";
        }
    }
}
