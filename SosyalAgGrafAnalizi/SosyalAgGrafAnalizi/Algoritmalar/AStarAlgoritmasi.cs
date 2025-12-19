using System;
using System.Collections.Generic;
using SosyalAgGrafAnalizi.GrafYapisi;

namespace SosyalAgGrafAnalizi.Algoritmalar
{
    public static class AStarAlgoritmasi
    {
        public class Sonuc
        {
            public List<int> Yol { get; set; } = new();
            public double ToplamMaliyet { get; set; }
        }

        private static double KenarMaliyeti(IGraf graf, int i, int j)
        {
            var a = graf.DugumGetir(i) ?? throw new InvalidOperationException($"Düğüm yok: {i}");
            var b = graf.DugumGetir(j) ?? throw new InvalidOperationException($"Düğüm yok: {j}");

            double dAkt = a.Aktiflik - b.Aktiflik;
            double dEtk = a.Etkilesim - b.Etkilesim;
            double dBag = a.BaglantiSayisi() - b.BaglantiSayisi();

            double dist2 = (dAkt * dAkt) + (dEtk * dEtk) + (dBag * dBag);

            // maliyet = 1 + dist2
            return 1.0 + dist2;
        }

        // Basit heuristic: özellik farklarının kareli toplamı (dist2)
        // (A* daha hızlı karar verir; Dijkstra'ya göre yönlendirilmiş arama)
        private static double Heuristic(IGraf graf, int n, int hedef)
        {
            var a = graf.DugumGetir(n)!;
            var b = graf.DugumGetir(hedef)!;

            double dAkt = a.Aktiflik - b.Aktiflik;
            double dEtk = a.Etkilesim - b.Etkilesim;
            double dBag = a.BaglantiSayisi() - b.BaglantiSayisi();

            return (dAkt * dAkt) + (dEtk * dEtk) + (dBag * dBag);
        }

        public static Sonuc Calistir(IGraf graf, int baslangic, int hedef)
        {
            if (!graf.DugumVarMi(baslangic))
                throw new InvalidOperationException("Başlangıç düğümü bulunamadı.");
            if (!graf.DugumVarMi(hedef))
                throw new InvalidOperationException("Hedef düğüm bulunamadı.");

            var gScore = new Dictionary<int, double>();
            var fScore = new Dictionary<int, double>();
            var prev = new Dictionary<int, int?>();

            foreach (var d in graf.TumDugumleriGetir())
            {
                gScore[d.Id] = double.PositiveInfinity;
                fScore[d.Id] = double.PositiveInfinity;
                prev[d.Id] = null;
            }

            gScore[baslangic] = 0;
            fScore[baslangic] = Heuristic(graf, baslangic, hedef);

            var pq = new PriorityQueue<int, double>();
            pq.Enqueue(baslangic, fScore[baslangic]);

            var kapali = new HashSet<int>();

            while (pq.Count > 0)
            {
                int u = pq.Dequeue();

                if (u == hedef) break;
                if (!kapali.Add(u)) continue;

                foreach (var v in graf.KomsulariGetir(u))
                {
                    double tentative = gScore[u] + KenarMaliyeti(graf, u, v);

                    if (tentative < gScore[v])
                    {
                        prev[v] = u;
                        gScore[v] = tentative;
                        fScore[v] = tentative + Heuristic(graf, v, hedef);
                        pq.Enqueue(v, fScore[v]);
                    }
                }
            }

            if (double.IsPositiveInfinity(gScore[hedef]))
                return new Sonuc { Yol = new List<int>(), ToplamMaliyet = double.PositiveInfinity };

            var yol = new List<int>();
            int? cur = hedef;
            while (cur != null)
            {
                yol.Add(cur.Value);
                cur = prev[cur.Value];
            }
            yol.Reverse();

            return new Sonuc { Yol = yol, ToplamMaliyet = gScore[hedef] };
        }
    }
}
