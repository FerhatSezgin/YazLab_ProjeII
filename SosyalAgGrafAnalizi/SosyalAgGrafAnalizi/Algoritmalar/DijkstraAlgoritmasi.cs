using System;
using System.Collections.Generic;
using System.Linq;
using SosyalAgGrafAnalizi.GrafYapisi;

namespace SosyalAgGrafAnalizi.Algoritmalar
{
    public static class DijkstraAlgoritmasi
    {
        public class Sonuc
        {
            public List<int> Yol { get; set; } = new();
            public double ToplamMaliyet { get; set; }
        }

        // Verilen formül: agirlik = 1 / (1 + dist2)
        // En kısa yol için maliyet = 1 / agirlik = (1 + dist2)
        private static double KenarMaliyeti(IGraf graf, int i, int j)
        {
            var a = graf.DugumGetir(i) ?? throw new InvalidOperationException($"Düğüm yok: {i}");
            var b = graf.DugumGetir(j) ?? throw new InvalidOperationException($"Düğüm yok: {j}");

            double dAkt = a.Aktiflik - b.Aktiflik;
            double dEtk = a.Etkilesim - b.Etkilesim;
            double dBag = a.BaglantiSayisi() - b.BaglantiSayisi();

            double dist2 = (dAkt * dAkt) + (dEtk * dEtk) + (dBag * dBag);

            double agirlik = 1.0 / (1.0 + dist2);
            double maliyet = 1.0 / agirlik; // = 1 + dist2

            return maliyet;
        }

        public static Sonuc Calistir(IGraf graf, int baslangic, int hedef)
        {
            if (!graf.DugumVarMi(baslangic))
                throw new InvalidOperationException("Başlangıç düğümü bulunamadı.");
            if (!graf.DugumVarMi(hedef))
                throw new InvalidOperationException("Hedef düğüm bulunamadı.");

            var dist = new Dictionary<int, double>();
            var prev = new Dictionary<int, int?>();

            foreach (var d in graf.TumDugumleriGetir())
            {
                dist[d.Id] = double.PositiveInfinity;
                prev[d.Id] = null;
            }

            dist[baslangic] = 0;

            var pq = new PriorityQueue<int, double>();
            pq.Enqueue(baslangic, 0);

            while (pq.Count > 0)
            {
                int u = pq.Dequeue();

                if (u == hedef) break;

                foreach (var v in graf.KomsulariGetir(u))
                {
                    double alt = dist[u] + KenarMaliyeti(graf, u, v);
                    if (alt < dist[v])
                    {
                        dist[v] = alt;
                        prev[v] = u;
                        pq.Enqueue(v, alt);
                    }
                }
            }

            if (double.IsPositiveInfinity(dist[hedef]))
                return new Sonuc { Yol = new List<int>(), ToplamMaliyet = double.PositiveInfinity };

            // Yol çıkarma
            var yol = new List<int>();
            int? cur = hedef;
            while (cur != null)
            {
                yol.Add(cur.Value);
                cur = prev[cur.Value];
            }
            yol.Reverse();

            return new Sonuc { Yol = yol, ToplamMaliyet = dist[hedef] };
        }
    }
}

