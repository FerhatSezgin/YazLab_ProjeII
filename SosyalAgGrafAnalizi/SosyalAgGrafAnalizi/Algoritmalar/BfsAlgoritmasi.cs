using System;
using System.Collections.Generic;
using SosyalAgGrafAnalizi.GrafYapisi;

namespace SosyalAgGrafAnalizi.Algoritmalar
{
    public static class BfsAlgoritmasi
    {
        public static List<int> Calistir(IGraf graf, int baslangicId)
        {
            if (!graf.DugumVarMi(baslangicId))
                throw new InvalidOperationException("Başlangıç düğümü bulunamadı.");

            var ziyaret = new HashSet<int>();
            var kuyruk = new Queue<int>();
            var sonuc = new List<int>();

            ziyaret.Add(baslangicId);
            kuyruk.Enqueue(baslangicId);

            while (kuyruk.Count > 0)
            {
                int u = kuyruk.Dequeue();
                sonuc.Add(u);

                foreach (var v in graf.KomsulariGetir(u))
                {
                    if (ziyaret.Add(v))
                        kuyruk.Enqueue(v);
                }
            }

            return sonuc;
        }
    }
}

