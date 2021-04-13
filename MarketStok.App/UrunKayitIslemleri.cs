using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStok.App
{
    public class UrunKayitIslemleri
    {
        public string Path { get; set; }
        public UrunKayitIslemleri()
         {
            Path = "D:\\kayit.txt";
         }
        public void UrunuKayitEt(Urun u)
        {
            string content = $"Ad:{u.Ad} Adet:{u.AdetSayisi} AdetTürü:{u.AdetTuru} Kategori:{u.Kategorii} ÜretimTarihi:{u.ÜretimTarihi}";
            File.AppendAllText(Path, content + Environment.NewLine, Encoding.UTF8);

        }

        public List<Urun> UrunleriGoster()
        {
            FileStream file = new FileStream(Path, FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(file);
            List<Urun> liste = new List<Urun>();

            string okunandosya = read.ReadLine();

            while (okunandosya != null)
            {
                Urun u = new Urun();
                string[] bolunmus = okunandosya.Split(' ');
                u.Ad = bolunmus[0].Split(':')[1];
                u.AdetSayisi = Convert.ToInt32(bolunmus[1].Split(':')[1]);
                u.AdetTuru = bolunmus[2].Split(':')[1];
                u.Kategorii = bolunmus[3].Split(':')[1];
                u.ÜretimTarihi = Convert.ToDateTime(bolunmus[4].Split(':')[1]);
                liste.Add(u);
                okunandosya = read.ReadLine();
            }

            return liste;
        }



    }
}
