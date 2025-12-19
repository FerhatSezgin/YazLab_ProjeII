using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosyalAgGrafAnalizi.Modeller
{
    public class Kenar
    {
        // Kenarın bağladığı düğümler
        public int BaslangicId { get; set; }
        public int BitisId { get; set; }

        // Kenar yönsüz olduğu için (i,j) ve (j,i) aynı kabul edilir
        // Ağırlık dinamik olarak hesaplanacağı için burada saklanmaz

        public Kenar(int baslangicId, int bitisId)
        {
            if (baslangicId == bitisId)
                throw new ArgumentException("Self-loop (bir düğümün kendisine bağlanması) yasaktır.");

            BaslangicId = baslangicId;
            BitisId = bitisId;
        }

        // Yönsüz kenar karşılaştırması
        public bool EsitMi(Kenar diger)
        {
            return
                (BaslangicId == diger.BaslangicId && BitisId == diger.BitisId) ||
                (BaslangicId == diger.BitisId && BitisId == diger.BaslangicId);
        }
    }
}
