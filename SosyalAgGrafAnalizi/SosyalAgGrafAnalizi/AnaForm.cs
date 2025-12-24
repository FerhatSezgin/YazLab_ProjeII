using SosyalAgGrafAnalizi.Algoritmalar;
using System.Drawing;
using System.Globalization;
using SosyalAgGrafAnalizi.GrafYapisi;
using SosyalAgGrafAnalizi.Modeller;
using SosyalAgGrafAnalizi.VeriIslemleri;
using System.Collections.Generic;

namespace SosyalAgGrafAnalizi
{
    public partial class AnaForm : Form
    {

        private readonly HashSet<string> _vurguluKenarlar = new();
        private readonly Dictionary<int, int> _dugumRenkIndex = new();
        private Color DugumRengiGetir(int nodeId)
        {
            Color[] palet =
            {
        Color.LightBlue,
        Color.LightGreen,
        Color.LightSalmon,
        Color.Khaki,
        Color.Plum,
        Color.LightPink,
        Color.LightCyan,
        Color.Orange,
        Color.YellowGreen,
        Color.SandyBrown
    };

            if (!_dugumRenkIndex.TryGetValue(nodeId, out int idx))
                return Color.LightBlue;

            return palet[idx % palet.Length];
        }



        private void YoluVurgula(List<int> yol)
        {
            _vurguluKenarlar.Clear();

            for (int i = 0; i < yol.Count - 1; i++)
            {
                int a = yol[i];
                int b = yol[i + 1];
                int min = Math.Min(a, b);
                int max = Math.Max(a, b);
                _vurguluKenarlar.Add($"{min}-{max}");
            }

            pnlCanvas.Invalidate();
        }

        private IGraf _graf = new Graf();
        private readonly Random _rnd = new Random();
        private const float DugumYaricap = 18f;
        private int? _seciliDugumId = null;


        public AnaForm()
        {
            InitializeComponent();
        }

        private int OkuInt(TextBox tb, string alanAdi)
        {
            if (!int.TryParse(tb.Text.Trim(), out int deger))
                throw new InvalidOperationException($"{alanAdi} sayı olmalı.");
            return deger;
        }

        private double OkuDouble(TextBox tb, string alanAdi)
        {
            var text = tb.Text.Trim().Replace(',', '.');
            if (!double.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out double deger))
                throw new InvalidOperationException($"{alanAdi} sayı olmalı. Örnek: 0.8");
            return deger;
        }

        private PointF RastgeleKonum()
        {
            int margin = 40;
            int w = Math.Max(margin + 10, pnlCanvas.Width - margin);
            int h = Math.Max(margin + 10, pnlCanvas.Height - margin);

            return new PointF(_rnd.Next(margin, w), _rnd.Next(margin, h));
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

                rtbCikti.AppendText("Komşuluk Listesi:\n");
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
                int id = OkuInt(txtDugumId, "Düğüm ID");
                string ad = txtDugumAd.Text.Trim();
                if (string.IsNullOrWhiteSpace(ad))
                    throw new InvalidOperationException("Ad boş olamaz.");

                double aktiflik = OkuDouble(txtAktiflik, "Aktiflik");
                if (aktiflik < 0 || aktiflik > 1)
                    throw new InvalidOperationException("Aktiflik 0 ile 1 arasında olmalı.");

                double etkilesim = OkuDouble(txtEtkilesim, "Etkileşim");
                if (etkilesim < 0) throw new InvalidOperationException("Etkileşim negatif olamaz.");

                var dugum = new Dugum(id, ad, aktiflik, etkilesim, RastgeleKonum());
                _graf.DugumEkle(dugum);

                rtbCikti.AppendText($"Düğüm eklendi: {dugum}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pnlCanvas.Invalidate();

        }

        private void btnKenarEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int a = OkuInt(txtBaslangicId, "Başlangıç ID");
                int b = OkuInt(txtBitisId, "Bitiş ID");

                _graf.KenarEkle(a, b);

                rtbCikti.AppendText($"Kenar eklendi: {a} <-> {b}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pnlCanvas.Invalidate();

        }

        private void btnDugumGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = OkuInt(txtDugumId, "Düğüm ID");
                string ad = txtDugumAd.Text.Trim();
                if (string.IsNullOrWhiteSpace(ad))
                    throw new InvalidOperationException("Ad boş olamaz.");

                double aktiflik = OkuDouble(txtAktiflik, "Aktiflik");
                if (aktiflik < 0 || aktiflik > 1)
                    throw new InvalidOperationException("Aktiflik 0 ile 1 arasında olmalı.");

                double etkilesim = OkuDouble(txtEtkilesim, "Etkileşim");
                if (etkilesim < 0)
                    throw new InvalidOperationException("Etkileşim negatif olamaz.");

                var eski = _graf.DugumGetir(id);
                if (eski == null)
                    throw new InvalidOperationException($"Düğüm bulunamadı: {id}");

                // Konumu koruyoruz (çizimde önemli olacak)
                var yeni = new Dugum(id, ad, aktiflik, etkilesim, eski.Konum);
                _graf.DugumGuncelle(yeni);

                rtbCikti.AppendText($"Düğüm güncellendi: {yeni}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pnlCanvas.Invalidate();

        }

        private void btnDugumSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = OkuInt(txtDugumId, "Düğüm ID");
                _graf.DugumSil(id);

                rtbCikti.AppendText($"Düğüm silindi: {id}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pnlCanvas.Invalidate();

        }

        private void btnKenarSil_Click(object sender, EventArgs e)
        {
            try
            {
                int a = OkuInt(txtBaslangicId, "Başlangıç ID");
                int b = OkuInt(txtBitisId, "Bitiş ID");

                _graf.KenarSil(a, b);

                rtbCikti.AppendText($"Kenar silindi: {a} <-> {b}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pnlCanvas.Invalidate();

        }

        private void btnJsonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using var sfd = new SaveFileDialog();
                sfd.Filter = "JSON Dosyası (*.json)|*.json";
                sfd.Title = "Grafı JSON Olarak Kaydet";
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
                ofd.Filter = "JSON Dosyası (*.json)|*.json";
                ofd.Title = "Graf JSON Yükle";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _graf = JsonKayitYukleyici.Yukle(ofd.FileName);
                    rtbCikti.AppendText($"JSON yüklendi: {ofd.FileName}\n");

                    // Hemen komşuluk listesini de gösterelim
                    btnKomsulukListele_Click(null, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pnlCanvas.Invalidate();

        }

        private void lblNodeAd_Click(object sender, EventArgs e)
        {

        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Canvas arka plan temizliği (önlem olarak, Panel BackColor yetmeyebilir)
            // g.Clear(Color.FromArgb(15, 23, 42)); // Bu paint içinde çağrılınca her şeyi siler, Panel'in kendi boyamasını ezer.

            var dugumler = _graf.TumDugumleriGetir();

            // 1) Kenarları çiz (yönsüz) - Dark theme için daha açık renk
            using var penEdge = new Pen(Color.FromArgb(100, 200, 220), 2); // Cam göbeği, transparan gibi
            using var penPath = new Pen(Color.Gold, 4); // Yol vurgusu sarı/altın

            foreach (var d in dugumler)
            {
                foreach (var komsuId in _graf.KomsulariGetir(d.Id))
                {
                    // aynı kenarı iki kez çizmemek için sadece küçük->büyük çiz
                    if (d.Id < komsuId)
                    {
                        var k = _graf.DugumGetir(komsuId);
                        if (k == null) continue;

                        int min = Math.Min(d.Id, komsuId);
                        int max = Math.Max(d.Id, komsuId);
                        string key = $"{min}-{max}";

                        var pen = _vurguluKenarlar.Contains(key) ? penPath : penEdge;
                        g.DrawLine(pen, d.Konum, k.Konum);
                    }
                }
            }

            // 2) Düğümleri çiz
            foreach (var d in dugumler)
            {
                bool secili = _seciliDugumId.HasValue && _seciliDugumId.Value == d.Id;

                var renk = secili ? Color.Orange : DugumRengiGetir(d.Id);
                using var brush = new SolidBrush(renk);
                // Düğüm çerçevesi beyaz olsun (koyu zemin üstünde)
                using var penNode = new Pen(Color.White, secili ? 3 : 2);

                float x = d.Konum.X - DugumYaricap;
                float y = d.Konum.Y - DugumYaricap;
                float w = DugumYaricap * 2;
                float h = DugumYaricap * 2;

                g.FillEllipse(brush, x, y, w, h);
                g.DrawEllipse(penNode, x, y, w, h);

                // ID yaz - Düğüm içi açık renk olduğu için yazı Siyah kalmalı
                var text = d.Id.ToString();
                var size = g.MeasureString(text, Font);
                g.DrawString(text, Font, Brushes.Black,
                    d.Konum.X - size.Width / 2,
                    d.Konum.Y - size.Height / 2);
            }
        }


        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            // Tıklanan nokta hangi düğüme yakın?
            var dugumler = _graf.TumDugumleriGetir();
            int? bulundu = null;

            foreach (var d in dugumler)
            {
                float dx = e.X - d.Konum.X;
                float dy = e.Y - d.Konum.Y;
                float dist2 = dx * dx + dy * dy;

                if (dist2 <= DugumYaricap * DugumYaricap)
                {
                    bulundu = d.Id;
                    break;
                }
            }

            _seciliDugumId = bulundu;

            if (bulundu.HasValue)
            {
                var d = _graf.DugumGetir(bulundu.Value);
                if (d != null)
                {
                    lblSeciliDugumBilgi.Text =
                        $"ID: {d.Id}\n" +
                        $"Ad: {d.Ad}\n" +
                        $"Aktiflik: {d.Aktiflik}\n" +
                        $"Etkileşim: {d.Etkilesim}\n" +
                        $"Bağlantı Sayısı: {d.BaglantiSayisi()}\n" +
                        $"Komşular: {string.Join(",", d.Komsular)}";
                }
            }
            else
            {
                lblSeciliDugumBilgi.Text = "Seçili düğüm yok";
            }

            pnlCanvas.Invalidate(); // yeniden çiz
        }



        private void btnDfs_Click(object sender, EventArgs e)
        {
            try
            {
                int baslangic = OkuInt(txtBaslangicId, "Başlangıç ID");
                var sonuc = DfsAlgoritmasi.Calistir(_graf, baslangic);

                rtbCikti.AppendText($"DFS ({baslangic}) sırası: {string.Join(" -> ", sonuc)}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBfs_Click(object sender, EventArgs e)
        {
            try
            {
                int baslangic = OkuInt(txtBaslangicId, "Başlangıç ID");
                var sonuc = BfsAlgoritmasi.Calistir(_graf, baslangic);

                rtbCikti.AppendText($"BFS ({baslangic}) sırası: {string.Join(" -> ", sonuc)}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            try
            {
                int bas = OkuInt(txtBaslangicId, "Başlangıç ID");
                int hedef = OkuInt(txtBitisId, "Hedef ID");

                var sonuc = DijkstraAlgoritmasi.Calistir(_graf, bas, hedef);

                if (sonuc.Yol.Count == 0)
                {
                    rtbCikti.AppendText($"Dijkstra: Yol bulunamadı ({bas} -> {hedef})\n");
                    _vurguluKenarlar.Clear();
                    pnlCanvas.Invalidate();
                    return;
                }

                rtbCikti.AppendText($"Dijkstra Yol: {string.Join(" -> ", sonuc.Yol)} | Maliyet: {sonuc.ToplamMaliyet:F3}\n");
                YoluVurgula(sonuc.Yol);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAStar_Click(object sender, EventArgs e)
        {
            try
            {
                int bas = OkuInt(txtBaslangicId, "Başlangıç ID");
                int hedef = OkuInt(txtBitisId, "Hedef ID");

                var sonuc = AStarAlgoritmasi.Calistir(_graf, bas, hedef);

                if (sonuc.Yol.Count == 0)
                {
                    rtbCikti.AppendText($"A*: Yol bulunamadı ({bas} -> {hedef})\n");
                    _vurguluKenarlar.Clear();
                    pnlCanvas.Invalidate();
                    return;
                }

                rtbCikti.AppendText($"A* Yol: {string.Join(" -> ", sonuc.Yol)} | Maliyet: {sonuc.ToplamMaliyet:F3}\n");
                YoluVurgula(sonuc.Yol);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMerkezilik_Click(object sender, EventArgs e)
        {
            try
            {
                var ilk5 = MerkezilikAlgoritmasi.EnEtkiliIlk5(_graf);

                rtbCikti.AppendText("=== En Etkili 5 Kullanıcı (Degree Centrality) ===\n");
                rtbCikti.AppendText(string.Format("{0,-5}{1,-10}{2,-10}\n", "Sıra", "Düğüm ID", "Derece"));
                rtbCikti.AppendText(new string('-', 30) + "\n");

                int sira = 1;
                foreach (var k in ilk5)
                {
                    rtbCikti.AppendText($"{sira}\t{k.DugumId}\t{k.Derece}\n");
                    sira++;
                }

                rtbCikti.AppendText("\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void lblTo_Click(object sender, EventArgs e)
        {

        }

        private void btnRenklendir_Click(object sender, EventArgs e)
        {
            try
            {
                _dugumRenkIndex.Clear();

                var bilesenSonuclari = WelshPowellRenklendirme.Calistir(_graf);

                rtbCikti.AppendText("=== Welsh–Powell Graf Renklendirme ===\n");

                foreach (var b in bilesenSonuclari)
                {
                    rtbCikti.AppendText($"Bileşen {b.BilesenNo} | Kullanılan renk sayısı: {b.KullanilanRenkSayisi}\n");
                    rtbCikti.AppendText(string.Format("{0,-10}{1,-10}\n", "Düğüm ID", "Renk No"));
                    rtbCikti.AppendText(new string('-', 22) + "\n");

                    foreach (var kv in b.DugumRenkleri.OrderBy(x => x.Key))
                    {
                        _dugumRenkIndex[kv.Key] = kv.Value;
                        rtbCikti.AppendText(string.Format("{0,-10}{1,-10}\n", kv.Key, kv.Value));
                    }

                    rtbCikti.AppendText("\n");
                }

                pnlCanvas.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCiktiTemizle_Click(object sender, EventArgs e)
        {
            rtbCikti.Clear();
        }
    }
}
