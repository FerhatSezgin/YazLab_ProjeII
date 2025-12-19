using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosyalAgGrafAnalizi.Modeller
{
    public class Dugum
    {
        // Temel bilgiler
        public int Id { get; set; }
        public string Ad { get; set; }

        // Dinamik ağırlık hesabında kullanılacak özellikler
        public double Aktiflik { get; set; }      // 0–1 arası değer
        public double Etkilesim { get; set; }     // etkileşim sayısı

        // Graf çizimi için (canvas üzerindeki konum)
        public PointF Konum { get; set; }

        // Komşu düğümler (ID listesi)
        public List<int> Komsular { get; set; }

        // Kurucu (constructor)
        public Dugum(int id, string ad, double aktiflik, double etkilesim, PointF konum)
        {
            Id = id;
            Ad = ad;
            Aktiflik = aktiflik;
            Etkilesim = etkilesim;
            Konum = konum;
            Komsular = new List<int>();
        }

        // Bağlantı sayısı (degree)
        public int BaglantiSayisi()
        {
            return Komsular.Count;
        }

        public override string ToString()
        {
            return $"{Id} - {Ad}";
        }
    }
}
