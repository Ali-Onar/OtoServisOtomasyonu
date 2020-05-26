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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        private void labelControl15_Click(object sender, EventArgs e)
        {

        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = db.TBLKATEGORI.Count().ToString();
            labelControl5.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            
            labelControl19.Text = (from x in db.TBLURUN
                                   orderby x.STOK descending
                                   select x.AD).FirstOrDefault();
            labelControl17.Text = (from x in db.TBLURUN
                                   orderby x.STOK ascending
                                   select x.AD).FirstOrDefault();

            labelControl13.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT descending
                                   select x.AD).FirstOrDefault();
            labelControl11.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT ascending
                                   select x.AD).FirstOrDefault();

            labelControl39.Text = (from x in db.TBLURUN
                                   select x.MARKA).Distinct().Count().ToString();

            labelControl35.Text = db.TBLURUN.Count().ToString();

            labelControl15.Text = db.makskategoriurun().FirstOrDefault();
        }
    }
}
