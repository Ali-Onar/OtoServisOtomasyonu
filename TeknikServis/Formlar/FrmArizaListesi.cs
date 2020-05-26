using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                               CARI = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                               x.GELISTARIHI,
                               x.CIKISTARIHI,
                               x.URUNSERINO,
                               DETAY = x.URUNDURUMDETAY
                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl3.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == true).ToString();
            labelControl5.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == false).ToString();
            labelControl11.Text = db.TBLURUN.Count().ToString();
            labelControl7.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Parça Bekliyor").ToString();
            labelControl1.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Mesaj Bekliyor").ToString();
            labelControl13.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "İptal Bekliyor").ToString();

            SqlConnection baglanti = new SqlConnection(@"Data Source=COMPUTERX\SQLEXPRESS;Initial Catalog=DbTeknikServis;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT URUNDURUMDETAY, COUNT(*) FROM TBLURUNKABUL GROUP BY URUNDURUMDETAY", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmArizaDetaylar fr = new FrmArizaDetaylar();
            fr.id = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            fr.serino = gridView1.GetFocusedRowCellValue("URUNSERINO").ToString();
            fr.Show();
        }
    }
}
