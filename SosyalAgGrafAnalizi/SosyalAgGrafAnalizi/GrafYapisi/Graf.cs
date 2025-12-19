using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SosyalAgGrafAnalizi.Modeller;

namespace SosyalAgGrafAnalizi.GrafYapisi
{
    public class Graf : IGraf
    {
        // Düğümler: Id -> Dugum
        private readonly Dictionary<int, Dugum> _dugumler = new();

        // Komşuluk listesi: Id -> komşu Id'leri
        private readonly Dictionary<int, HashSet<int>> _komsuluk = new();

        public void DugumEkle(Dugum dugum)
        {
            if (dugum == null) throw new ArgumentNullException(nameof(dugum));
            if (_dugumler.ContainsKey(dugum.Id))
                throw new InvalidOperationException($"Bu ID zaten var: {dugum.Id}");

            _dugumler[dugum.Id] = dugum;
            _komsuluk[dugum.Id] = new HashSet<int>();
        }

        public void DugumSil(int dugumId)
        {
            if (!_dugumler.ContainsKey(dugumId))
                throw new InvalidOperationException($"Düğüm bulunamadı: {dugumId}");

            // Bu düğüme bağlı tüm kenarları kaldır
            var komsular = _komsuluk[dugumId].ToList();
            foreach (var k in komsular)
            {
                KenarSil(dugumId, k);
            }

            _komsuluk.Remove(dugumId);
            _dugumler.Remove(dugumId);
        }

        public void DugumGuncelle(Dugum dugum)
        {
            if (dugum == null) throw new ArgumentNullException(nameof(dugum));
            if (!_dugumler.ContainsKey(dugum.Id))
                throw new InvalidOperationException($"Güncellenecek düğüm bulunamadı: {dugum.Id}");

            // Komşuları koru
            var eskiKomsular = _dugumler[dugum.Id].Komsular;

            _dugumler[dugum.Id] = dugum;
            _dugumler[dugum.Id].Komsular = eskiKomsular;
        }

        public void KenarEkle(int baslangicId, int bitisId)
        {
            if (baslangicId == bitisId)
                throw new InvalidOperationException("Self-loop yasaktır (düğüm kendisine bağlanamaz).");

            if (!DugumVarMi(baslangicId) || !DugumVarMi(bitisId))
                throw new InvalidOperationException("Kenar eklemek için iki düğüm de var olmalı.");

            if (KenarVarMi(baslangicId, bitisId))
                throw new InvalidOperationException("Bu kenar zaten var.");

            // yönsüz: iki tarafa da ekle
            _komsuluk[baslangicId].Add(bitisId);
            _komsuluk[bitisId].Add(baslangicId);

            // Dugum içindeki komşu listelerini de güncel tut
            _dugumler[baslangicId].Komsular.Add(bitisId);
            _dugumler[bitisId].Komsular.Add(baslangicId);
        }

        public void KenarSil(int baslangicId, int bitisId)
        {
            if (!KenarVarMi(baslangicId, bitisId))
                throw new InvalidOperationException("Silinecek kenar bulunamadı.");

            _komsuluk[baslangicId].Remove(bitisId);
            _komsuluk[bitisId].Remove(baslangicId);

            _dugumler[baslangicId].Komsular.Remove(bitisId);
            _dugumler[bitisId].Komsular.Remove(baslangicId);
        }

        public bool DugumVarMi(int dugumId) => _dugumler.ContainsKey(dugumId);

        public bool KenarVarMi(int baslangicId, int bitisId)
        {
            return _komsuluk.ContainsKey(baslangicId) && _komsuluk[baslangicId].Contains(bitisId);
        }

        public Dugum? DugumGetir(int dugumId)
        {
            _dugumler.TryGetValue(dugumId, out var dugum);
            return dugum;
        }

        public List<Dugum> TumDugumleriGetir()
        {
            return _dugumler.Values.OrderBy(d => d.Id).ToList();
        }

        public List<int> KomsulariGetir(int dugumId)
        {
            if (!_komsuluk.ContainsKey(dugumId))
                throw new InvalidOperationException($"Düğüm bulunamadı: {dugumId}");

            return _komsuluk[dugumId].OrderBy(x => x).ToList();
        }

        public Dictionary<int, List<int>> KomsulukListesiOlustur()
        {
            // rapor/çıktı için: HashSet -> List
            var sonuc = new Dictionary<int, List<int>>();

            foreach (var id in _dugumler.Keys.OrderBy(x => x))
            {
                sonuc[id] = _komsuluk[id].OrderBy(x => x).ToList();
            }

            return sonuc;
        }
    }
}
