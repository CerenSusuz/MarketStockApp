using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStok.App
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            frmUrunEkle frm = new frmUrunEkle();
            this.Hide();
            frm.Show();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            frmStok frm = new frmStok();
            frm.Show();
        }
    }
}
