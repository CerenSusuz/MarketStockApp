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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();

        }
        
        private void btnKayitEt_Click(object sender, EventArgs e)
        {

            Urun u = new Urun()
            {
                Ad = textBox1.Text,
                AdetSayisi = Convert.ToInt32(textBox2.Text),
                AdetTuru = comboBox1.Text,
                Kategorii = comboBox2.Text,
                ÜretimTarihi = DateTime.Now,
            };
            UrunKayitIslemleri kytis = new UrunKayitIslemleri();
            kytis.UrunuKayitEt(u);
            MessageBox.Show("Ürün Eklendi!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";

        }

        public enum Kategori
        {
            Elektronik,
            Gıda,
            Giyim
        }
        public enum Adet
        {
            Kg,
            Tane
        }
        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetNames(typeof(Adet));
            comboBox2.DataSource = Enum.GetNames(typeof(Kategori));
            textBox4.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStok f = new frmStok();
            f.Show();
        }
    }
}
