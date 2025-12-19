using System;
using System.Collections.Generic;
using System.Linq;
using SosyalAgGrafAnalizi.GrafYapisi;

namespace SosyalAgGrafAnalizi.Algoritmalar
{
    public static class MerkezilikAlgoritmasi
    {
        public class Kayit
        {
            public int DugumId { get; set; }
            public int Derece { get; set; }
        }

        public static List<Kayit> DereceleriHesapla(IGraf graf)
        {
            return graf.TumDugumleriGetir()
                .Select(d => new Kayit
                {
                    DugumId = d.Id,
                    Derece = graf.KomsulariGetir(d.Id).Distinct().Count()
                })
                .OrderByDescending(x => x.Derece)
                .ThenBy(x => x.DugumId)
                .ToList();
        }

        public static List<Kayit> EnEtkiliIlk5(IGraf graf)
        {
            return DereceleriHesapla(graf).Take(5).ToList();
        }
    }
}
