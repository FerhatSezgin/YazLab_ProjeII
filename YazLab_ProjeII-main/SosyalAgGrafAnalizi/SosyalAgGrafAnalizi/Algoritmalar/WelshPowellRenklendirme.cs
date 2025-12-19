using System;
using System.Collections.Generic;
using System.Linq;
using SosyalAgGrafAnalizi.GrafYapisi;

namespace SosyalAgGrafAnalizi.Algoritmalar
{
    public static class WelshPowellRenklendirme
    {
        public class BilesenSonuc
        {
            public int BilesenNo { get; set; }
            public Dictionary<int, int> DugumRenkleri { get; set; } = new(); // nodeId -> colorIndex
            public int KullanilanRenkSayisi { get; set; }
        }

        public static List<BilesenSonuc> Calistir(IGraf graf)
        {
            var bilesenler = BagliBilesenleriBul(graf);
            var sonuc = new List<BilesenSonuc>();

            int no = 1;
            foreach (var bilesen in bilesenler)
            {
                var renklendirme = WelshPowellTekBilesen(graf, bilesen);
                sonuc.Add(new BilesenSonuc
                {
                    BilesenNo = no++,
                    DugumRenkleri = renklendirme,
                    KullanilanRenkSayisi = renklendirme.Values.DefaultIfEmpty(-1).Max() + 1
                });
            }

            return sonuc;
        }

        private static List<List<int>> BagliBilesenleriBul(IGraf graf)
        {
            var ziyaret = new HashSet<int>();
            var bilesenler = new List<List<int>>();

            foreach (var d in graf.TumDugumleriGetir())
            {
                if (ziyaret.Contains(d.Id)) continue;

                var bilesen = new List<int>();
                var q = new Queue<int>();
                q.Enqueue(d.Id);
                ziyaret.Add(d.Id);

                while (q.Count > 0)
                {
                    var u = q.Dequeue();
                    bilesen.Add(u);

                    foreach (var v in graf.KomsulariGetir(u))
                    {
                        if (ziyaret.Add(v))
                            q.Enqueue(v);
                    }
                }

                bilesenler.Add(bilesen);
            }

            return bilesenler;
        }

        private static Dictionary<int, int> WelshPowellTekBilesen(IGraf graf, List<int> dugumler)
        {
            // 1) Dereceye göre büyükten küçüğe sırala
            var sirali = dugumler
                .OrderByDescending(id => graf.KomsulariGetir(id).Distinct().Count())
                .ThenBy(id => id)
                .ToList();

            var renk = new Dictionary<int, int>(); // nodeId -> colorIndex

            int mevcutRenk = 0;

            foreach (var u in sirali)
            {
                if (renk.ContainsKey(u)) continue;

                renk[u] = mevcutRenk;

                // aynı rengi verebileceğimiz diğer düğümleri sırayla dene
                foreach (var v in sirali)
                {
                    if (renk.ContainsKey(v)) continue;

                    bool komsuAyniRenkMi = renk
                        .Where(kv => kv.Value == mevcutRenk)
                        .Select(kv => kv.Key)
                        .Any(renkli => graf.KomsulariGetir(renkli).Contains(v));

                    if (!komsuAyniRenkMi)
                        renk[v] = mevcutRenk;
                }

                mevcutRenk++;
            }

            return renk;
        }
    }
}
