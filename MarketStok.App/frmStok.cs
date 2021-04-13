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
    public partial class frmStok : Form
    {
        public frmStok()
        {
            InitializeComponent();
        }

        private void frmStok_Load(object sender, EventArgs e)
        {

           UrunKayitIslemleri kyt = new UrunKayitIslemleri();
           dataGridView1.DataSource = kyt.UrunleriGoster();
        }
    }
}
