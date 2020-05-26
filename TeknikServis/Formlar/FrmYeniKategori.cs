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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtKategoriAd.Text != "" && TxtKategoriAd.Text.Length<=30) { 
            TBLKATEGORI t = new TBLKATEGORI();
            t.AD = TxtKategoriAd.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla kaydedildi!");
            }
            else
            {
                MessageBox.Show("Lütfen karakter sayısını 0-30 arasında giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmYeniKategori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
