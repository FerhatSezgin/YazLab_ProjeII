using System.Drawing;
using System.Globalization;
using SosyalAgGrafAnalizi.GrafYapisi;
using SosyalAgGrafAnalizi.Modeller;
using SosyalAgGrafAnalizi.VeriIslemleri;

namespace SosyalAgGrafAnalizi
{
    public partial class AnaForm : Form
    {
        private IGraf _graf = new Graf();
        private readonly Random _rnd = new Random();

        public AnaForm()
        {
            InitializeComponent();
        }

        private int OkuInt(TextBox tb, string alanAdi)
        {
            if (!int.TryParse(tb.Text.Trim(), out int deger))
                throw new InvalidOperationException($"{alanAdi} sayý olmalý.");
            return deger;
        }

        private double OkuDouble(TextBox tb, string alanAdi)
        {
            var text = tb.Text.Trim().Replace(',', '.');
            if (!double.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out double deger))
                throw new InvalidOperationException($"{alanAdi} sayý olmalý. Örnek: 0.8");
            return deger;
        }

        private PointF RastgeleKonum()
        {
            return new PointF(_rnd.Next(50, 500), _rnd.Next(50, 350));
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblFrom_Click(object sender, EventArgs e)
        {

        }

        private void btnKomsulukListele_Click(object sender, EventArgs e)
        {
            try
            {
                var liste = _graf.KomsulukListesiOlustur();
                rtbCikti.Clear();

                rtbCikti.AppendText("Komþuluk Listesi:\n");
                foreach (var kv in liste)
                {
                    rtbCikti.AppendText($"{kv.Key}: {string.Join(",", kv.Value)}\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDugumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = OkuInt(txtDugumId, "Düðüm ID");
                string ad = txtDugumAd.Text.Trim();
                if (string.IsNullOrWhiteSpace(ad))
                    throw new InvalidOperationException("Ad boþ olamaz.");

                double aktiflik = OkuDouble(txtAktiflik, "Aktiflik");
                if (aktiflik < 0 || aktiflik > 1)
                    throw new InvalidOperationException("Aktiflik 0 ile 1 arasýnda olmalý.");

                double etkilesim = OkuDouble(txtEtkilesim, "Etkileþim");
                if (etkilesim < 0) throw new InvalidOperationException("Etkileþim negatif olamaz.");

                var dugum = new Dugum(id, ad, aktiflik, etkilesim, RastgeleKonum());
                _graf.DugumEkle(dugum);

                rtbCikti.AppendText($"Düðüm eklendi: {dugum}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKenarEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int a = OkuInt(txtBaslangicId, "Baþlangýç ID");
                int b = OkuInt(txtBitisId, "Bitiþ ID");

                _graf.KenarEkle(a, b);

                rtbCikti.AppendText($"Kenar eklendi: {a} <-> {b}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDugumGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = OkuInt(txtDugumId, "Düðüm ID");
                string ad = txtDugumAd.Text.Trim();
                if (string.IsNullOrWhiteSpace(ad))
                    throw new InvalidOperationException("Ad boþ olamaz.");

                double aktiflik = OkuDouble(txtAktiflik, "Aktiflik");
                if (aktiflik < 0 || aktiflik > 1)
                    throw new InvalidOperationException("Aktiflik 0 ile 1 arasýnda olmalý.");

                double etkilesim = OkuDouble(txtEtkilesim, "Etkileþim");
                if (etkilesim < 0)
                    throw new InvalidOperationException("Etkileþim negatif olamaz.");

                var eski = _graf.DugumGetir(id);
                if (eski == null)
                    throw new InvalidOperationException($"Düðüm bulunamadý: {id}");

                // Konumu koruyoruz (çizimde önemli olacak)
                var yeni = new Dugum(id, ad, aktiflik, etkilesim, eski.Konum);
                _graf.DugumGuncelle(yeni);

                rtbCikti.AppendText($"Düðüm güncellendi: {yeni}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDugumSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = OkuInt(txtDugumId, "Düðüm ID");
                _graf.DugumSil(id);

                rtbCikti.AppendText($"Düðüm silindi: {id}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKenarSil_Click(object sender, EventArgs e)
        {
            try
            {
                int a = OkuInt(txtBaslangicId, "Baþlangýç ID");
                int b = OkuInt(txtBitisId, "Bitiþ ID");

                _graf.KenarSil(a, b);

                rtbCikti.AppendText($"Kenar silindi: {a} <-> {b}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnJsonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using var sfd = new SaveFileDialog();
                sfd.Filter = "JSON Dosyasý (*.json)|*.json";
                sfd.Title = "Grafý JSON Olarak Kaydet";
                sfd.FileName = "graf.json";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    JsonKayitYukleyici.Kaydet(_graf, sfd.FileName);
                    rtbCikti.AppendText($"JSON kaydedildi: {sfd.FileName}\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnJsonYukle_Click(object sender, EventArgs e)
        {
            try
            {
                using var ofd = new OpenFileDialog();
                ofd.Filter = "JSON Dosyasý (*.json)|*.json";
                ofd.Title = "Graf JSON Yükle";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _graf = JsonKayitYukleyici.Yukle(ofd.FileName);
                    rtbCikti.AppendText($"JSON yüklendi: {ofd.FileName}\n");

                    // Hemen komþuluk listesini de gösterelim
                    btnKomsulukListele_Click(null, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblNodeAd_Click(object sender, EventArgs e)
        {

        }
    }
}
