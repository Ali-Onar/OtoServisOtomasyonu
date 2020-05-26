using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeknikServis.Formlar
{
    public partial class FrmCariiller : Form
    {
        public FrmCariiller()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        SqlConnection baglanti = new SqlConnection(@"Data Source=COMPUTERX\SQLEXPRESS;Initial Catalog=DbTeknikServis;Integrated Security=True");
        private void FrmCariiller_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 22);
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 29);
            //chartControl1.Series["Series 1"].Points.AddPoint("Bursa", 32);
            //chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 17);

            gridControl1.DataSource = db.TBLCARI.OrderBy(x => x.IL).
                GroupBy(y => y.IL).
                Select(z => new { İL = z.Key, toplam = z.Count() }).ToList();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select IL, COUNT (*) FROM TBLCARI group by IL", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }
    }
}
