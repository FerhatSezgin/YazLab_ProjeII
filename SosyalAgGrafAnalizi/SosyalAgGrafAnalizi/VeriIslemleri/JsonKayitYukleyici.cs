using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using SosyalAgGrafAnalizi.GrafYapisi;
using SosyalAgGrafAnalizi.Modeller;

namespace SosyalAgGrafAnalizi.VeriIslemleri
{
    public static class JsonKayitYukleyici
    {
        // JSON'a kaydedeceğimiz sade model
        private class GrafDto
        {
            public List<DugumDto> Dugumler { get; set; } = new();
            public List<KenarDto> Kenarlar { get; set; } = new();
        }

        private class DugumDto
        {
            public int Id { get; set; }
            public string Ad { get; set; } = "";
            public double Aktiflik { get; set; }
            public double Etkilesim { get; set; }

            // Konum kaydı (çizim için)
            public float X { get; set; }
            public float Y { get; set; }
        }

        private class KenarDto
        {
            public int A { get; set; }
            public int B { get; set; }
        }

        private static JsonSerializerOptions Options => new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true,
            NumberHandling = JsonNumberHandling.AllowReadingFromString
        };

        public static void Kaydet(IGraf graf, string dosyaYolu)
        {
            var dto = new GrafDto();

            // Düğümler
            foreach (var d in graf.TumDugumleriGetir())
            {
                dto.Dugumler.Add(new DugumDto
                {
                    Id = d.Id,
                    Ad = d.Ad,
                    Aktiflik = d.Aktiflik,
                    Etkilesim = d.Etkilesim,
                    X = d.Konum.X,
                    Y = d.Konum.Y
                });
            }

            // Kenarlar (yönsüz olduğu için tekrarları engelle)
            var eklendi = new HashSet<string>();
            foreach (var d in graf.TumDugumleriGetir())
            {
                foreach (var k in graf.KomsulariGetir(d.Id))
                {
                    int a = d.Id;
                    int b = k;
                    int min = a < b ? a : b;
                    int max = a < b ? b : a;

                    string key = $"{min}-{max}";
                    if (eklendi.Add(key))
                    {
                        dto.Kenarlar.Add(new KenarDto { A = min, B = max });
                    }
                }
            }

            var json = JsonSerializer.Serialize(dto, Options);
            File.WriteAllText(dosyaYolu, json);
        }

        public static IGraf Yukle(string dosyaYolu)
        {
            var json = File.ReadAllText(dosyaYolu);
            var dto = JsonSerializer.Deserialize<GrafDto>(json, Options) ?? new GrafDto();

            IGraf graf = new Graf();

            // Düğümler
            foreach (var d in dto.Dugumler)
            {
                var dugum = new Dugum(
                    d.Id,
                    d.Ad,
                    d.Aktiflik,
                    d.Etkilesim,
                    new System.Drawing.PointF(d.X, d.Y)
                );

                graf.DugumEkle(dugum);
            }

            // Kenarlar
            foreach (var e in dto.Kenarlar)
            {
                // Düğümler yoksa hata vermesin diye kontrol
                if (graf.DugumVarMi(e.A) && graf.DugumVarMi(e.B))
                    graf.KenarEkle(e.A, e.B);
            }

            return graf;
        }
    }
}
