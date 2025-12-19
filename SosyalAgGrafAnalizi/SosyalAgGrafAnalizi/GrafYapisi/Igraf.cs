using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SosyalAgGrafAnalizi.Modeller;

namespace SosyalAgGrafAnalizi.GrafYapisi
{
    public interface IGraf
    {
        // Düğüm işlemleri
        void DugumEkle(Dugum dugum);
        void DugumSil(int dugumId);
        void DugumGuncelle(Dugum dugum);

        // Kenar işlemleri (yönsüz)
        void KenarEkle(int baslangicId, int bitisId);
        void KenarSil(int baslangicId, int bitisId);

        // Sorgular
        bool DugumVarMi(int dugumId);
        bool KenarVarMi(int baslangicId, int bitisId);

        Dugum? DugumGetir(int dugumId);
        List<Dugum> TumDugumleriGetir();
        List<int> KomsulariGetir(int dugumId);

        // Komşuluk listesi çıktısı (rapor/çıktı için)
        Dictionary<int, List<int>> KomsulukListesiOlustur();
    }
}
