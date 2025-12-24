namespace SosyalAgGrafAnalizi
{
    partial class AnaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLeft = new Panel();
            lblHeaderDugum = new Label();
            lblHeaderBaglanti = new Label();
            btnDugumSil = new Button();
            btnDugumGuncelle = new Button();
            btnDugumEkle = new Button();
            txtEtkilesim = new TextBox();
            lblEtkilesim = new Label();
            txtAktiflik = new TextBox();
            lblAktiflik = new Label();
            txtDugumAd = new TextBox();
            lblNodeAd = new Label();
            txtDugumId = new TextBox();
            lblNodeId = new Label();
            btnKenarSil = new Button();
            btnKenarEkle = new Button();
            txtBitisId = new TextBox();
            lblTo = new Label();
            txtBaslangicId = new TextBox();
            lblFrom = new Label();
            pnlBottom = new Panel();
            lblHeaderVeri = new Label();
            btnCiktiTemizle = new Button();
            btnRenklendir = new Button();
            btnMerkezilik = new Button();
            btnAStar = new Button();
            btnDijkstra = new Button();
            btnDfs = new Button();
            btnBfs = new Button();
            grpDugumBilgi = new GroupBox();
            lblSeciliDugumBilgi = new Label();
            btnJsonYukle = new Button();
            btnJsonKaydet = new Button();
            rtbCikti = new RichTextBox();
            btnKomsulukListele = new Button();
            pnlCanvas = new Panel();
            pnlLeft.SuspendLayout();
            pnlBottom.SuspendLayout();
            grpDugumBilgi.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(30, 41, 59);
            pnlLeft.Controls.Add(lblHeaderDugum);
            pnlLeft.Controls.Add(lblHeaderBaglanti);
            pnlLeft.Controls.Add(btnDugumSil);
            pnlLeft.Controls.Add(btnDugumGuncelle);
            pnlLeft.Controls.Add(btnDugumEkle);
            pnlLeft.Controls.Add(txtEtkilesim);
            pnlLeft.Controls.Add(lblEtkilesim);
            pnlLeft.Controls.Add(txtAktiflik);
            pnlLeft.Controls.Add(lblAktiflik);
            pnlLeft.Controls.Add(txtDugumAd);
            pnlLeft.Controls.Add(lblNodeAd);
            pnlLeft.Controls.Add(txtDugumId);
            pnlLeft.Controls.Add(lblNodeId);
            pnlLeft.Controls.Add(btnKenarSil);
            pnlLeft.Controls.Add(btnKenarEkle);
            pnlLeft.Controls.Add(txtBitisId);
            pnlLeft.Controls.Add(lblTo);
            pnlLeft.Controls.Add(txtBaslangicId);
            pnlLeft.Controls.Add(lblFrom);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(260, 775);
            pnlLeft.TabIndex = 0;
            // 
            // lblHeaderDugum
            // 
            lblHeaderDugum.AutoSize = true;
            lblHeaderDugum.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderDugum.ForeColor = Color.LightSkyBlue;
            lblHeaderDugum.Location = new Point(12, 190);
            lblHeaderDugum.Name = "lblHeaderDugum";
            lblHeaderDugum.Size = new Size(161, 23);
            lblHeaderDugum.TabIndex = 17;
            lblHeaderDugum.Text = "DÜĞÜM YÖNETİMİ";
            // 
            // lblHeaderBaglanti
            // 
            lblHeaderBaglanti.AutoSize = true;
            lblHeaderBaglanti.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderBaglanti.ForeColor = Color.LightSkyBlue;
            lblHeaderBaglanti.Location = new Point(12, 15);
            lblHeaderBaglanti.Name = "lblHeaderBaglanti";
            lblHeaderBaglanti.Size = new Size(180, 23);
            lblHeaderBaglanti.TabIndex = 16;
            lblHeaderBaglanti.Text = "BAĞLANTI YÖNETİMİ";
            // 
            // btnDugumSil
            // 
            btnDugumSil.BackColor = Color.FromArgb(185, 28, 28);
            btnDugumSil.FlatAppearance.BorderSize = 0;
            btnDugumSil.FlatStyle = FlatStyle.Flat;
            btnDugumSil.ForeColor = Color.White;
            btnDugumSil.Location = new Point(12, 450);
            btnDugumSil.Name = "btnDugumSil";
            btnDugumSil.Size = new Size(235, 30);
            btnDugumSil.TabIndex = 10;
            btnDugumSil.Text = "Düğüm Sil";
            btnDugumSil.UseVisualStyleBackColor = false;
            btnDugumSil.Click += btnDugumSil_Click;
            // 
            // btnDugumGuncelle
            // 
            btnDugumGuncelle.BackColor = Color.FromArgb(51, 65, 85);
            btnDugumGuncelle.FlatAppearance.BorderSize = 0;
            btnDugumGuncelle.FlatStyle = FlatStyle.Flat;
            btnDugumGuncelle.ForeColor = Color.White;
            btnDugumGuncelle.Location = new Point(12, 414);
            btnDugumGuncelle.Name = "btnDugumGuncelle";
            btnDugumGuncelle.Size = new Size(235, 30);
            btnDugumGuncelle.TabIndex = 9;
            btnDugumGuncelle.Text = "Düğüm Güncelle";
            btnDugumGuncelle.UseVisualStyleBackColor = false;
            btnDugumGuncelle.Click += btnDugumGuncelle_Click;
            // 
            // btnDugumEkle
            // 
            btnDugumEkle.BackColor = Color.FromArgb(37, 99, 235);
            btnDugumEkle.FlatAppearance.BorderSize = 0;
            btnDugumEkle.FlatStyle = FlatStyle.Flat;
            btnDugumEkle.ForeColor = Color.White;
            btnDugumEkle.Location = new Point(12, 378);
            btnDugumEkle.Name = "btnDugumEkle";
            btnDugumEkle.Size = new Size(235, 30);
            btnDugumEkle.TabIndex = 8;
            btnDugumEkle.Text = "Düğüm Ekle";
            btnDugumEkle.UseVisualStyleBackColor = false;
            btnDugumEkle.Click += btnDugumEkle_Click;
            // 
            // txtEtkilesim
            // 
            txtEtkilesim.BackColor = Color.FromArgb(51, 65, 85);
            txtEtkilesim.BorderStyle = BorderStyle.FixedSingle;
            txtEtkilesim.ForeColor = Color.White;
            txtEtkilesim.Location = new Point(111, 336);
            txtEtkilesim.Name = "txtEtkilesim";
            txtEtkilesim.Size = new Size(136, 27);
            txtEtkilesim.TabIndex = 7;
            // 
            // lblEtkilesim
            // 
            lblEtkilesim.AutoSize = true;
            lblEtkilesim.ForeColor = Color.White;
            lblEtkilesim.Location = new Point(12, 338);
            lblEtkilesim.Name = "lblEtkilesim";
            lblEtkilesim.Size = new Size(68, 20);
            lblEtkilesim.TabIndex = 6;
            lblEtkilesim.Text = "Etkileşim";
            // 
            // txtAktiflik
            // 
            txtAktiflik.BackColor = Color.FromArgb(51, 65, 85);
            txtAktiflik.BorderStyle = BorderStyle.FixedSingle;
            txtAktiflik.ForeColor = Color.White;
            txtAktiflik.Location = new Point(111, 302);
            txtAktiflik.Name = "txtAktiflik";
            txtAktiflik.Size = new Size(136, 27);
            txtAktiflik.TabIndex = 5;
            // 
            // lblAktiflik
            // 
            lblAktiflik.AutoSize = true;
            lblAktiflik.ForeColor = Color.White;
            lblAktiflik.Location = new Point(12, 304);
            lblAktiflik.Name = "lblAktiflik";
            lblAktiflik.Size = new Size(91, 20);
            lblAktiflik.TabIndex = 4;
            lblAktiflik.Text = "Aktiflik (0-1)";
            // 
            // txtDugumAd
            // 
            txtDugumAd.BackColor = Color.FromArgb(51, 65, 85);
            txtDugumAd.BorderStyle = BorderStyle.FixedSingle;
            txtDugumAd.ForeColor = Color.White;
            txtDugumAd.Location = new Point(111, 267);
            txtDugumAd.Name = "txtDugumAd";
            txtDugumAd.Size = new Size(136, 27);
            txtDugumAd.TabIndex = 3;
            // 
            // lblNodeAd
            // 
            lblNodeAd.AutoSize = true;
            lblNodeAd.ForeColor = Color.White;
            lblNodeAd.Location = new Point(12, 269);
            lblNodeAd.Name = "lblNodeAd";
            lblNodeAd.Size = new Size(28, 20);
            lblNodeAd.TabIndex = 2;
            lblNodeAd.Text = "Ad";
            lblNodeAd.Click += lblNodeAd_Click;
            // 
            // txtDugumId
            // 
            txtDugumId.BackColor = Color.FromArgb(51, 65, 85);
            txtDugumId.BorderStyle = BorderStyle.FixedSingle;
            txtDugumId.ForeColor = Color.White;
            txtDugumId.Location = new Point(111, 233);
            txtDugumId.Name = "txtDugumId";
            txtDugumId.Size = new Size(136, 27);
            txtDugumId.TabIndex = 1;
            // 
            // lblNodeId
            // 
            lblNodeId.AutoSize = true;
            lblNodeId.ForeColor = Color.White;
            lblNodeId.Location = new Point(12, 235);
            lblNodeId.Name = "lblNodeId";
            lblNodeId.Size = new Size(77, 20);
            lblNodeId.TabIndex = 0;
            lblNodeId.Text = "Düğüm ID";
            lblNodeId.Click += label1_Click;
            // 
            // btnKenarSil
            // 
            btnKenarSil.BackColor = Color.FromArgb(185, 28, 28);
            btnKenarSil.FlatAppearance.BorderSize = 0;
            btnKenarSil.FlatStyle = FlatStyle.Flat;
            btnKenarSil.ForeColor = Color.White;
            btnKenarSil.Location = new Point(135, 115);
            btnKenarSil.Name = "btnKenarSil";
            btnKenarSil.Size = new Size(112, 29);
            btnKenarSil.TabIndex = 16;
            btnKenarSil.Text = "Kenar Sil";
            btnKenarSil.UseVisualStyleBackColor = false;
            btnKenarSil.Click += btnKenarSil_Click;
            // 
            // btnKenarEkle
            // 
            btnKenarEkle.BackColor = Color.FromArgb(37, 99, 235);
            btnKenarEkle.FlatAppearance.BorderSize = 0;
            btnKenarEkle.FlatStyle = FlatStyle.Flat;
            btnKenarEkle.ForeColor = Color.White;
            btnKenarEkle.Location = new Point(12, 115);
            btnKenarEkle.Name = "btnKenarEkle";
            btnKenarEkle.Size = new Size(112, 29);
            btnKenarEkle.TabIndex = 15;
            btnKenarEkle.Text = "Kenar Ekle";
            btnKenarEkle.UseVisualStyleBackColor = false;
            btnKenarEkle.Click += btnKenarEkle_Click;
            // 
            // txtBitisId
            // 
            txtBitisId.BackColor = Color.FromArgb(51, 65, 85);
            txtBitisId.BorderStyle = BorderStyle.FixedSingle;
            txtBitisId.ForeColor = Color.White;
            txtBitisId.Location = new Point(111, 75);
            txtBitisId.Name = "txtBitisId";
            txtBitisId.Size = new Size(136, 27);
            txtBitisId.TabIndex = 14;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.ForeColor = Color.White;
            lblTo.Location = new Point(12, 77);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(56, 20);
            lblTo.TabIndex = 13;
            lblTo.Text = "Bitiş ID";
            lblTo.Click += lblTo_Click;
            // 
            // txtBaslangicId
            // 
            txtBaslangicId.BackColor = Color.FromArgb(51, 65, 85);
            txtBaslangicId.BorderStyle = BorderStyle.FixedSingle;
            txtBaslangicId.ForeColor = Color.White;
            txtBaslangicId.Location = new Point(111, 41);
            txtBaslangicId.Name = "txtBaslangicId";
            txtBaslangicId.Size = new Size(136, 27);
            txtBaslangicId.TabIndex = 12;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.ForeColor = Color.White;
            lblFrom.Location = new Point(12, 44);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(91, 20);
            lblFrom.TabIndex = 11;
            lblFrom.Text = "Başlangıç ID";
            lblFrom.Click += lblFrom_Click;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.FromArgb(30, 41, 59);
            pnlBottom.Controls.Add(lblHeaderVeri);
            pnlBottom.Controls.Add(btnCiktiTemizle);
            pnlBottom.Controls.Add(btnRenklendir);
            pnlBottom.Controls.Add(btnMerkezilik);
            pnlBottom.Controls.Add(btnAStar);
            pnlBottom.Controls.Add(btnDijkstra);
            pnlBottom.Controls.Add(btnDfs);
            pnlBottom.Controls.Add(btnBfs);
            pnlBottom.Controls.Add(grpDugumBilgi);
            pnlBottom.Controls.Add(btnJsonYukle);
            pnlBottom.Controls.Add(btnJsonKaydet);
            pnlBottom.Controls.Add(rtbCikti);
            pnlBottom.Controls.Add(btnKomsulukListele);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(260, 529);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(926, 246);
            pnlBottom.TabIndex = 1;
            // 
            // lblHeaderVeri
            // 
            lblHeaderVeri.AutoSize = true;
            lblHeaderVeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderVeri.ForeColor = Color.LightSkyBlue;
            lblHeaderVeri.Location = new Point(10, 10);
            lblHeaderVeri.Name = "lblHeaderVeri";
            lblHeaderVeri.Size = new Size(134, 23);
            lblHeaderVeri.TabIndex = 18;
            lblHeaderVeri.Text = "VERİ İŞLEMLERİ";
            // 
            // btnCiktiTemizle
            // 
            btnCiktiTemizle.BackColor = Color.FromArgb(51, 65, 85);
            btnCiktiTemizle.FlatAppearance.BorderSize = 0;
            btnCiktiTemizle.FlatStyle = FlatStyle.Flat;
            btnCiktiTemizle.ForeColor = Color.LightGray;
            btnCiktiTemizle.Location = new Point(589, 203);
            btnCiktiTemizle.Name = "btnCiktiTemizle";
            btnCiktiTemizle.Size = new Size(75, 31);
            btnCiktiTemizle.TabIndex = 29;
            btnCiktiTemizle.Text = "Temizle";
            btnCiktiTemizle.UseVisualStyleBackColor = false;
            btnCiktiTemizle.Click += btnCiktiTemizle_Click;
            // 
            // btnRenklendir
            // 
            btnRenklendir.BackColor = Color.FromArgb(51, 65, 85);
            btnRenklendir.FlatAppearance.BorderSize = 0;
            btnRenklendir.FlatStyle = FlatStyle.Flat;
            btnRenklendir.ForeColor = Color.White;
            btnRenklendir.Location = new Point(10, 201);
            btnRenklendir.Margin = new Padding(3, 4, 3, 4);
            btnRenklendir.Name = "btnRenklendir";
            btnRenklendir.Size = new Size(161, 31);
            btnRenklendir.TabIndex = 28;
            btnRenklendir.Text = "Graf Renklendir";
            btnRenklendir.UseVisualStyleBackColor = false;
            btnRenklendir.Click += btnRenklendir_Click;
            // 
            // btnMerkezilik
            // 
            btnMerkezilik.BackColor = Color.FromArgb(51, 65, 85);
            btnMerkezilik.FlatAppearance.BorderSize = 0;
            btnMerkezilik.FlatStyle = FlatStyle.Flat;
            btnMerkezilik.ForeColor = Color.White;
            btnMerkezilik.Location = new Point(10, 162);
            btnMerkezilik.Margin = new Padding(3, 4, 3, 4);
            btnMerkezilik.Name = "btnMerkezilik";
            btnMerkezilik.Size = new Size(161, 31);
            btnMerkezilik.TabIndex = 27;
            btnMerkezilik.Text = "En Etkili 5 (Merkezilik)";
            btnMerkezilik.UseVisualStyleBackColor = false;
            btnMerkezilik.Click += btnMerkezilik_Click;
            // 
            // btnAStar
            // 
            btnAStar.BackColor = Color.FromArgb(51, 65, 85);
            btnAStar.FlatAppearance.BorderSize = 0;
            btnAStar.FlatStyle = FlatStyle.Flat;
            btnAStar.ForeColor = Color.White;
            btnAStar.Location = new Point(10, 123);
            btnAStar.Margin = new Padding(3, 4, 3, 4);
            btnAStar.Name = "btnAStar";
            btnAStar.Size = new Size(161, 31);
            btnAStar.TabIndex = 26;
            btnAStar.Text = "A* Yol Bul";
            btnAStar.UseVisualStyleBackColor = false;
            btnAStar.Click += btnAStar_Click;
            // 
            // btnDijkstra
            // 
            btnDijkstra.BackColor = Color.FromArgb(51, 65, 85);
            btnDijkstra.FlatAppearance.BorderSize = 0;
            btnDijkstra.FlatStyle = FlatStyle.Flat;
            btnDijkstra.ForeColor = Color.White;
            btnDijkstra.Location = new Point(10, 84);
            btnDijkstra.Margin = new Padding(3, 4, 3, 4);
            btnDijkstra.Name = "btnDijkstra";
            btnDijkstra.Size = new Size(161, 31);
            btnDijkstra.TabIndex = 25;
            btnDijkstra.Text = "Dijkstra Yol Bul";
            btnDijkstra.UseVisualStyleBackColor = false;
            btnDijkstra.Click += btnDijkstra_Click;
            // 
            // btnDfs
            // 
            btnDfs.BackColor = Color.FromArgb(51, 65, 85);
            btnDfs.FlatAppearance.BorderSize = 0;
            btnDfs.FlatStyle = FlatStyle.Flat;
            btnDfs.ForeColor = Color.White;
            btnDfs.Location = new Point(10, 45);
            btnDfs.Margin = new Padding(3, 4, 3, 4);
            btnDfs.Name = "btnDfs";
            btnDfs.Size = new Size(85, 31);
            btnDfs.TabIndex = 24;
            btnDfs.Text = "DFS Çalıştır";
            btnDfs.UseVisualStyleBackColor = false;
            btnDfs.Click += btnDfs_Click;
            // 
            // btnBfs
            // 
            btnBfs.BackColor = Color.FromArgb(51, 65, 85);
            btnBfs.FlatAppearance.BorderSize = 0;
            btnBfs.FlatStyle = FlatStyle.Flat;
            btnBfs.ForeColor = Color.White;
            btnBfs.Location = new Point(101, 45);
            btnBfs.Margin = new Padding(3, 4, 3, 4);
            btnBfs.Name = "btnBfs";
            btnBfs.Size = new Size(70, 31);
            btnBfs.TabIndex = 23;
            btnBfs.Text = "BFS Çalıştır";
            btnBfs.UseVisualStyleBackColor = false;
            btnBfs.Click += btnBfs_Click;
            // 
            // grpDugumBilgi
            // 
            grpDugumBilgi.Controls.Add(lblSeciliDugumBilgi);
            grpDugumBilgi.ForeColor = Color.White;
            grpDugumBilgi.Location = new Point(670, 10);
            grpDugumBilgi.Name = "grpDugumBilgi";
            grpDugumBilgi.Size = new Size(244, 185);
            grpDugumBilgi.TabIndex = 22;
            grpDugumBilgi.TabStop = false;
            grpDugumBilgi.Text = "Düğüm Bilgisi";
            // 
            // lblSeciliDugumBilgi
            // 
            lblSeciliDugumBilgi.AutoSize = true;
            lblSeciliDugumBilgi.Location = new Point(6, 25);
            lblSeciliDugumBilgi.Name = "lblSeciliDugumBilgi";
            lblSeciliDugumBilgi.Size = new Size(124, 20);
            lblSeciliDugumBilgi.TabIndex = 0;
            lblSeciliDugumBilgi.Text = "Seçili Düğüm Yok";
            // 
            // btnJsonYukle
            // 
            btnJsonYukle.BackColor = Color.FromArgb(51, 65, 85);
            btnJsonYukle.FlatAppearance.BorderSize = 0;
            btnJsonYukle.FlatStyle = FlatStyle.Flat;
            btnJsonYukle.ForeColor = Color.White;
            btnJsonYukle.Location = new Point(796, 203);
            btnJsonYukle.Name = "btnJsonYukle";
            btnJsonYukle.Size = new Size(118, 29);
            btnJsonYukle.TabIndex = 20;
            btnJsonYukle.Text = "Dosya Yükle";
            btnJsonYukle.UseVisualStyleBackColor = false;
            btnJsonYukle.Click += btnJsonYukle_Click;
            // 
            // btnJsonKaydet
            // 
            btnJsonKaydet.BackColor = Color.FromArgb(51, 65, 85);
            btnJsonKaydet.FlatAppearance.BorderSize = 0;
            btnJsonKaydet.FlatStyle = FlatStyle.Flat;
            btnJsonKaydet.ForeColor = Color.White;
            btnJsonKaydet.Location = new Point(670, 203);
            btnJsonKaydet.Name = "btnJsonKaydet";
            btnJsonKaydet.Size = new Size(120, 29);
            btnJsonKaydet.TabIndex = 19;
            btnJsonKaydet.Text = "Farklı Kaydet";
            btnJsonKaydet.UseVisualStyleBackColor = false;
            btnJsonKaydet.Click += btnJsonKaydet_Click;
            // 
            // rtbCikti
            // 
            rtbCikti.BackColor = Color.FromArgb(15, 23, 42);
            rtbCikti.BorderStyle = BorderStyle.None;
            rtbCikti.Font = new Font("Consolas", 9F);
            rtbCikti.ForeColor = Color.LightGreen;
            rtbCikti.Location = new Point(191, 10);
            rtbCikti.Name = "rtbCikti";
            rtbCikti.Size = new Size(473, 185);
            rtbCikti.TabIndex = 18;
            rtbCikti.Text = "";
            // 
            // btnKomsulukListele
            // 
            btnKomsulukListele.BackColor = Color.FromArgb(51, 65, 85);
            btnKomsulukListele.FlatAppearance.BorderSize = 0;
            btnKomsulukListele.FlatStyle = FlatStyle.Flat;
            btnKomsulukListele.ForeColor = Color.White;
            btnKomsulukListele.Location = new Point(191, 203);
            btnKomsulukListele.Name = "btnKomsulukListele";
            btnKomsulukListele.Size = new Size(125, 29);
            btnKomsulukListele.TabIndex = 17;
            btnKomsulukListele.Text = "Komşuluk Listesi";
            btnKomsulukListele.UseVisualStyleBackColor = false;
            btnKomsulukListele.Click += btnKomsulukListele_Click;
            // 
            // pnlCanvas
            // 
            pnlCanvas.BackColor = Color.FromArgb(15, 23, 42);
            pnlCanvas.BorderStyle = BorderStyle.FixedSingle;
            pnlCanvas.Dock = DockStyle.Fill;
            pnlCanvas.Location = new Point(260, 0);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(926, 529);
            pnlCanvas.TabIndex = 21;
            pnlCanvas.Paint += pnlCanvas_Paint;
            pnlCanvas.MouseClick += pnlCanvas_MouseClick;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(1186, 775);
            Controls.Add(pnlCanvas);
            Controls.Add(pnlBottom);
            Controls.Add(pnlLeft);
            Name = "AnaForm";
            Text = "Sosyal Ağ Analizi";
            Load += AnaForm_Load;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            grpDugumBilgi.ResumeLayout(false);
            grpDugumBilgi.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblHeaderBaglanti;
        private System.Windows.Forms.Label lblHeaderDugum;
        private System.Windows.Forms.Label lblHeaderVeri;

        private System.Windows.Forms.Label lblNodeId;
        private System.Windows.Forms.TextBox txtDugumId;
        private System.Windows.Forms.Label lblNodeAd;
        private System.Windows.Forms.TextBox txtDugumAd;
        private System.Windows.Forms.Label lblAktiflik;
        private System.Windows.Forms.TextBox txtAktiflik;
        private System.Windows.Forms.Label lblEtkilesim;
        private System.Windows.Forms.TextBox txtEtkilesim;
        private System.Windows.Forms.Button btnDugumEkle;
        private System.Windows.Forms.Button btnDugumGuncelle;
        private System.Windows.Forms.Button btnDugumSil;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtBaslangicId;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtBitisId;
        private System.Windows.Forms.Button btnKenarEkle;
        private System.Windows.Forms.Button btnKenarSil;
        private System.Windows.Forms.Button btnKomsulukListele;
        private System.Windows.Forms.RichTextBox rtbCikti;
        private System.Windows.Forms.Button btnJsonKaydet;
        private System.Windows.Forms.Button btnJsonYukle;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.GroupBox grpDugumBilgi;
        private System.Windows.Forms.Label lblSeciliDugumBilgi;
        private System.Windows.Forms.Button btnBfs;
        private System.Windows.Forms.Button btnDfs;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.Button btnAStar;
        private System.Windows.Forms.Button btnMerkezilik;
        private System.Windows.Forms.Button btnRenklendir;
        private System.Windows.Forms.Button btnCiktiTemizle;
    }
}
