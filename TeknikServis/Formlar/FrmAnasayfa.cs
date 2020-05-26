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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLURUN
                                       select new
                                       {
                                           x.AD,
                                           x.STOK
                                       }).Where(x => x.STOK <15 ).ToList();

            gridControl2.DataSource = (from y in db.TBLCARI
                                       select new
                                       {
                                           y.AD,
                                           y.SOYAD,
                                           y.TELEFON
                                       }).ToList();

            gridControl4.DataSource = db.urunkategori().ToList();


            DateTime bugun = DateTime.Today;
            var deger = (from x in db.TBLNOTLARIM.OrderBy(y => y.ID)
                         where (x.TARIH == bugun)
                         select new
                         {
                             x.BASLIK,
                             x.ICERIK
                         });
            gridControl3.DataSource = deger.ToList();

            //string konu1, ad1;
            //konu1 = db.TBLILETISIM.First(x => x.ID == 1).KONU;
            //ad1 = db.TBLILETISIM.First(x => x.ID == 1).ADSOYAD;
            //labelControl1.Text = konu1 + " - " + ad1;

            //konu1 = db.TBLILETISIM.First(x => x.ID == 1).KONU;
            //ad1 = db.TBLILETISIM.First(x => x.ID == 1).ADSOYAD;
            //labelControl1.Text = konu1 + " - " + ad1;

            //konu1 = db.TBLILETISIM.First(x => x.ID == 1).KONU;
            //ad1 = db.TBLILETISIM.First(x => x.ID == 1).ADSOYAD;
            //labelControl1.Text = konu1 + " - " + ad1;

            //konu1 = db.TBLILETISIM.First(x => x.ID == 1).KONU;
            //ad1 = db.TBLILETISIM.First(x => x.ID == 1).ADSOYAD;
            //labelControl1.Text = konu1 + " - " + ad1;

            //konu1 = db.TBLILETISIM.First(x => x.ID == 1).KONU;
            //ad1 = db.TBLILETISIM.First(x => x.ID == 1).ADSOYAD;
            //labelControl1.Text = konu1 + " - " + ad1;
        }
    }
}
