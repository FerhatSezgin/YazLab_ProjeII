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
            lblNodeId = new Label();
            txtDugumId = new TextBox();
            lblNodeAd = new Label();
            txtDugumAd = new TextBox();
            lblAktiflik = new Label();
            txtAktiflik = new TextBox();
            lblEtkilesim = new Label();
            txtEtkilesim = new TextBox();
            btnDugumEkle = new Button();
            btnDugumGuncelle = new Button();
            btnDugumSil = new Button();
            lblFrom = new Label();
            txtBaslangicId = new TextBox();
            lblTo = new Label();
            txtBitisId = new TextBox();
            btnKenarEkle = new Button();
            btnKenarSil = new Button();
            btnKomsulukListele = new Button();
            rtbCikti = new RichTextBox();
            btnJsonKaydet = new Button();
            btnJsonYukle = new Button();
            pnlCanvas = new Panel();
            grpDugumBilgi = new GroupBox();
            lblSeciliDugumBilgi = new Label();
            btnBfs = new Button();
            btnDfs = new Button();
            btnDijkstra = new Button();
            btnAStar = new Button();
            btnMerkezilik = new Button();
            btnRenklendir = new Button();
            grpDugumBilgi.SuspendLayout();
            SuspendLayout();
            // 
            // lblNodeId
            // 
            lblNodeId.AutoSize = true;
            lblNodeId.Location = new Point(195, 9);
            lblNodeId.Name = "lblNodeId";
            lblNodeId.Size = new Size(61, 15);
            lblNodeId.TabIndex = 0;
            lblNodeId.Text = "Düğüm ID";
            lblNodeId.Click += label1_Click;
            // 
            // txtDugumId
            // 
            txtDugumId.Location = new Point(275, 9);
            txtDugumId.Margin = new Padding(3, 2, 3, 2);
            txtDugumId.Name = "txtDugumId";
            txtDugumId.Size = new Size(110, 23);
            txtDugumId.TabIndex = 1;
            // 
            // lblNodeAd
            // 
            lblNodeAd.AutoSize = true;
            lblNodeAd.Location = new Point(195, 34);
            lblNodeAd.Name = "lblNodeAd";
            lblNodeAd.Size = new Size(22, 15);
            lblNodeAd.TabIndex = 2;
            lblNodeAd.Text = "Ad";
            lblNodeAd.Click += lblNodeAd_Click;
            // 
            // txtDugumAd
            // 
            txtDugumAd.Location = new Point(275, 34);
            txtDugumAd.Margin = new Padding(3, 2, 3, 2);
            txtDugumAd.Name = "txtDugumAd";
            txtDugumAd.Size = new Size(110, 23);
            txtDugumAd.TabIndex = 3;
            // 
            // lblAktiflik
            // 
            lblAktiflik.AutoSize = true;
            lblAktiflik.Location = new Point(195, 58);
            lblAktiflik.Name = "lblAktiflik";
            lblAktiflik.Size = new Size(72, 15);
            lblAktiflik.TabIndex = 4;
            lblAktiflik.Text = "Aktiflik (0-1)";
            // 
            // txtAktiflik
            // 
            txtAktiflik.Location = new Point(275, 58);
            txtAktiflik.Margin = new Padding(3, 2, 3, 2);
            txtAktiflik.Name = "txtAktiflik";
            txtAktiflik.Size = new Size(110, 23);
            txtAktiflik.TabIndex = 5;
            // 
            // lblEtkilesim
            // 
            lblEtkilesim.AutoSize = true;
            lblEtkilesim.Location = new Point(195, 83);
            lblEtkilesim.Name = "lblEtkilesim";
            lblEtkilesim.Size = new Size(54, 15);
            lblEtkilesim.TabIndex = 6;
            lblEtkilesim.Text = "Etkileşim";
            // 
            // txtEtkilesim
            // 
            txtEtkilesim.Location = new Point(275, 83);
            txtEtkilesim.Margin = new Padding(3, 2, 3, 2);
            txtEtkilesim.Name = "txtEtkilesim";
            txtEtkilesim.Size = new Size(110, 23);
            txtEtkilesim.TabIndex = 7;
            // 
            // btnDugumEkle
            // 
            btnDugumEkle.Location = new Point(275, 115);
            btnDugumEkle.Margin = new Padding(3, 2, 3, 2);
            btnDugumEkle.Name = "btnDugumEkle";
            btnDugumEkle.Size = new Size(108, 22);
            btnDugumEkle.TabIndex = 8;
            btnDugumEkle.Text = "Düğüm Ekle";
            btnDugumEkle.UseVisualStyleBackColor = true;
            btnDugumEkle.Click += btnDugumEkle_Click;
            // 
            // btnDugumGuncelle
            // 
            btnDugumGuncelle.Location = new Point(275, 141);
            btnDugumGuncelle.Margin = new Padding(3, 2, 3, 2);
            btnDugumGuncelle.Name = "btnDugumGuncelle";
            btnDugumGuncelle.Size = new Size(119, 22);
            btnDugumGuncelle.TabIndex = 9;
            btnDugumGuncelle.Text = "Düğüm Güncelle";
            btnDugumGuncelle.UseVisualStyleBackColor = true;
            btnDugumGuncelle.Click += btnDugumGuncelle_Click;
            // 
            // btnDugumSil
            // 
            btnDugumSil.Location = new Point(275, 167);
            btnDugumSil.Margin = new Padding(3, 2, 3, 2);
            btnDugumSil.Name = "btnDugumSil";
            btnDugumSil.Size = new Size(119, 22);
            btnDugumSil.TabIndex = 10;
            btnDugumSil.Text = "Düğüm Sil";
            btnDugumSil.UseVisualStyleBackColor = true;
            btnDugumSil.Click += btnDugumSil_Click;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(10, 7);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(71, 15);
            lblFrom.TabIndex = 11;
            lblFrom.Text = "Başlangıç ID";
            lblFrom.Click += lblFrom_Click;
            // 
            // txtBaslangicId
            // 
            txtBaslangicId.Location = new Point(10, 24);
            txtBaslangicId.Margin = new Padding(3, 2, 3, 2);
            txtBaslangicId.Name = "txtBaslangicId";
            txtBaslangicId.Size = new Size(110, 23);
            txtBaslangicId.TabIndex = 12;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(10, 58);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(43, 15);
            lblTo.TabIndex = 13;
            lblTo.Text = "Bitiş ID";
            lblTo.Click += lblTo_Click;
            // 
            // txtBitisId
            // 
            txtBitisId.Location = new Point(9, 75);
            txtBitisId.Margin = new Padding(3, 2, 3, 2);
            txtBitisId.Name = "txtBitisId";
            txtBitisId.Size = new Size(110, 23);
            txtBitisId.TabIndex = 14;
            // 
            // btnKenarEkle
            // 
            btnKenarEkle.Location = new Point(10, 115);
            btnKenarEkle.Margin = new Padding(3, 2, 3, 2);
            btnKenarEkle.Name = "btnKenarEkle";
            btnKenarEkle.Size = new Size(82, 22);
            btnKenarEkle.TabIndex = 15;
            btnKenarEkle.Text = "Kenar Ekle";
            btnKenarEkle.UseVisualStyleBackColor = true;
            btnKenarEkle.Click += btnKenarEkle_Click;
            // 
            // btnKenarSil
            // 
            btnKenarSil.Location = new Point(10, 141);
            btnKenarSil.Margin = new Padding(3, 2, 3, 2);
            btnKenarSil.Name = "btnKenarSil";
            btnKenarSil.Size = new Size(82, 22);
            btnKenarSil.TabIndex = 16;
            btnKenarSil.Text = "Kenar Sil";
            btnKenarSil.UseVisualStyleBackColor = true;
            btnKenarSil.Click += btnKenarSil_Click;
            // 
            // btnKomsulukListele
            // 
            btnKomsulukListele.Location = new Point(9, 250);
            btnKomsulukListele.Margin = new Padding(3, 2, 3, 2);
            btnKomsulukListele.Name = "btnKomsulukListele";
            btnKomsulukListele.Size = new Size(109, 22);
            btnKomsulukListele.TabIndex = 17;
            btnKomsulukListele.Text = "Komşuluk Listesi";
            btnKomsulukListele.UseVisualStyleBackColor = true;
            btnKomsulukListele.Click += btnKomsulukListele_Click;
            // 
            // rtbCikti
            // 
            rtbCikti.Location = new Point(10, 276);
            rtbCikti.Margin = new Padding(3, 2, 3, 2);
            rtbCikti.Name = "rtbCikti";
            rtbCikti.Size = new Size(239, 157);
            rtbCikti.TabIndex = 18;
            rtbCikti.Text = "";
            // 
            // btnJsonKaydet
            // 
            btnJsonKaydet.Location = new Point(731, 377);
            btnJsonKaydet.Margin = new Padding(3, 2, 3, 2);
            btnJsonKaydet.Name = "btnJsonKaydet";
            btnJsonKaydet.Size = new Size(112, 22);
            btnJsonKaydet.TabIndex = 19;
            btnJsonKaydet.Text = "JSON Kaydett";
            btnJsonKaydet.UseVisualStyleBackColor = true;
            btnJsonKaydet.Click += btnJsonKaydet_Click;
            // 
            // btnJsonYukle
            // 
            btnJsonYukle.Location = new Point(731, 411);
            btnJsonYukle.Margin = new Padding(3, 2, 3, 2);
            btnJsonYukle.Name = "btnJsonYukle";
            btnJsonYukle.Size = new Size(112, 22);
            btnJsonYukle.TabIndex = 20;
            btnJsonYukle.Text = "JSON Yükle";
            btnJsonYukle.UseVisualStyleBackColor = true;
            btnJsonYukle.Click += btnJsonYukle_Click;
            // 
            // pnlCanvas
            // 
            pnlCanvas.BackColor = Color.White;
            pnlCanvas.BorderStyle = BorderStyle.FixedSingle;
            pnlCanvas.Location = new Point(493, 9);
            pnlCanvas.Margin = new Padding(3, 2, 3, 2);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(350, 215);
            pnlCanvas.TabIndex = 21;
            pnlCanvas.Paint += pnlCanvas_Paint;
            pnlCanvas.MouseClick += pnlCanvas_MouseClick;
            // 
            // grpDugumBilgi
            // 
            grpDugumBilgi.Controls.Add(lblSeciliDugumBilgi);
            grpDugumBilgi.Location = new Point(717, 229);
            grpDugumBilgi.Margin = new Padding(3, 2, 3, 2);
            grpDugumBilgi.Name = "grpDugumBilgi";
            grpDugumBilgi.Padding = new Padding(3, 2, 3, 2);
            grpDugumBilgi.Size = new Size(126, 123);
            grpDugumBilgi.TabIndex = 22;
            grpDugumBilgi.TabStop = false;
            grpDugumBilgi.Text = "Düğüm Bilgisi";
            // 
            // lblSeciliDugumBilgi
            // 
            lblSeciliDugumBilgi.AutoSize = true;
            lblSeciliDugumBilgi.Location = new Point(5, 28);
            lblSeciliDugumBilgi.Name = "lblSeciliDugumBilgi";
            lblSeciliDugumBilgi.Size = new Size(99, 15);
            lblSeciliDugumBilgi.TabIndex = 0;
            lblSeciliDugumBilgi.Text = "Seçili Düğüm Yok";
            // 
            // btnBfs
            // 
            btnBfs.Location = new Point(255, 276);
            btnBfs.Name = "btnBfs";
            btnBfs.Size = new Size(75, 23);
            btnBfs.TabIndex = 23;
            btnBfs.Text = "BFS Çalıştır";
            btnBfs.UseVisualStyleBackColor = true;
            btnBfs.Click += btnBfs_Click;
            // 
            // btnDfs
            // 
            btnDfs.Location = new Point(255, 305);
            btnDfs.Name = "btnDfs";
            btnDfs.Size = new Size(75, 23);
            btnDfs.TabIndex = 24;
            btnDfs.Text = "DFS Çalıştır";
            btnDfs.UseVisualStyleBackColor = true;
            btnDfs.Click += btnDfs_Click;
            // 
            // btnDijkstra
            // 
            btnDijkstra.Location = new Point(255, 334);
            btnDijkstra.Name = "btnDijkstra";
            btnDijkstra.Size = new Size(75, 23);
            btnDijkstra.TabIndex = 25;
            btnDijkstra.Text = "Dijkstra Yol";
            btnDijkstra.UseVisualStyleBackColor = true;
            btnDijkstra.Click += btnDijkstra_Click;
            // 
            // btnAStar
            // 
            btnAStar.Location = new Point(255, 363);
            btnAStar.Name = "btnAStar";
            btnAStar.Size = new Size(75, 23);
            btnAStar.TabIndex = 26;
            btnAStar.Text = "A* Yol";
            btnAStar.UseVisualStyleBackColor = true;
            btnAStar.Click += btnAStar_Click;
            // 
            // btnMerkezilik
            // 
            btnMerkezilik.Location = new Point(124, 250);
            btnMerkezilik.Name = "btnMerkezilik";
            btnMerkezilik.Size = new Size(99, 23);
            btnMerkezilik.TabIndex = 27;
            btnMerkezilik.Text = "En Etkili 5";
            btnMerkezilik.UseVisualStyleBackColor = true;
            btnMerkezilik.Click += btnMerkezilik_Click;
            // 
            // btnRenklendir
            // 
            btnRenklendir.Location = new Point(493, 229);
            btnRenklendir.Name = "btnRenklendir";
            btnRenklendir.Size = new Size(99, 23);
            btnRenklendir.TabIndex = 28;
            btnRenklendir.Text = "Graf Renklendir";
            btnRenklendir.UseVisualStyleBackColor = true;
            btnRenklendir.Click += btnRenklendir_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 444);
            Controls.Add(btnRenklendir);
            Controls.Add(btnMerkezilik);
            Controls.Add(btnAStar);
            Controls.Add(btnDijkstra);
            Controls.Add(btnDfs);
            Controls.Add(btnBfs);
            Controls.Add(grpDugumBilgi);
            Controls.Add(pnlCanvas);
            Controls.Add(btnJsonYukle);
            Controls.Add(btnJsonKaydet);
            Controls.Add(rtbCikti);
            Controls.Add(btnKomsulukListele);
            Controls.Add(btnKenarSil);
            Controls.Add(btnKenarEkle);
            Controls.Add(txtBitisId);
            Controls.Add(lblTo);
            Controls.Add(txtBaslangicId);
            Controls.Add(lblFrom);
            Controls.Add(btnDugumSil);
            Controls.Add(btnDugumGuncelle);
            Controls.Add(btnDugumEkle);
            Controls.Add(txtEtkilesim);
            Controls.Add(lblEtkilesim);
            Controls.Add(txtAktiflik);
            Controls.Add(lblAktiflik);
            Controls.Add(txtDugumAd);
            Controls.Add(lblNodeAd);
            Controls.Add(txtDugumId);
            Controls.Add(lblNodeId);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AnaForm";
            Text = "Form1";
            grpDugumBilgi.ResumeLayout(false);
            grpDugumBilgi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNodeId;
        private TextBox txtDugumId;
        private Label lblNodeAd;
        private TextBox txtDugumAd;
        private Label lblAktiflik;
        private TextBox txtAktiflik;
        private Label lblEtkilesim;
        private TextBox txtEtkilesim;
        private Button btnDugumEkle;
        private Button btnDugumGuncelle;
        private Button btnDugumSil;
        private Label lblFrom;
        private TextBox txtBaslangicId;
        private Label lblTo;
        private TextBox txtBitisId;
        private Button btnKenarEkle;
        private Button btnKenarSil;
        private Button btnKomsulukListele;
        private RichTextBox rtbCikti;
        private Button btnJsonKaydet;
        private Button btnJsonYukle;
        private Panel pnlCanvas;
        private GroupBox grpDugumBilgi;
        private Label lblSeciliDugumBilgi;
        private Button btnBfs;
        private Button btnDfs;
        private Button btnDijkstra;
        private Button btnAStar;
        private Button btnMerkezilik;
        private Button btnRenklendir;
    }
}
