using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class FrmGuvenlik : Form
    {
        public FrmGuvenlik()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGuvenlik_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLADMIN
                           select new
                           {
                               u.SIFRE
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
