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
            grpDugumBilgi.SuspendLayout();
            SuspendLayout();
            // 
            // lblNodeId
            // 
            lblNodeId.AutoSize = true;
            lblNodeId.Location = new Point(223, 12);
            lblNodeId.Name = "lblNodeId";
            lblNodeId.Size = new Size(77, 20);
            lblNodeId.TabIndex = 0;
            lblNodeId.Text = "Düğüm ID";
            lblNodeId.Click += label1_Click;
            // 
            // txtDugumId
            // 
            txtDugumId.Location = new Point(354, 12);
            txtDugumId.Name = "txtDugumId";
            txtDugumId.Size = new Size(125, 27);
            txtDugumId.TabIndex = 1;
            // 
            // lblNodeAd
            // 
            lblNodeAd.AutoSize = true;
            lblNodeAd.Location = new Point(223, 45);
            lblNodeAd.Name = "lblNodeAd";
            lblNodeAd.Size = new Size(28, 20);
            lblNodeAd.TabIndex = 2;
            lblNodeAd.Text = "Ad";
            lblNodeAd.Click += lblNodeAd_Click;
            // 
            // txtDugumAd
            // 
            txtDugumAd.Location = new Point(354, 45);
            txtDugumAd.Name = "txtDugumAd";
            txtDugumAd.Size = new Size(125, 27);
            txtDugumAd.TabIndex = 3;
            // 
            // lblAktiflik
            // 
            lblAktiflik.AutoSize = true;
            lblAktiflik.Location = new Point(223, 78);
            lblAktiflik.Name = "lblAktiflik";
            lblAktiflik.Size = new Size(91, 20);
            lblAktiflik.TabIndex = 4;
            lblAktiflik.Text = "Aktiflik (0-1)";
            // 
            // txtAktiflik
            // 
            txtAktiflik.Location = new Point(354, 78);
            txtAktiflik.Name = "txtAktiflik";
            txtAktiflik.Size = new Size(125, 27);
            txtAktiflik.TabIndex = 5;
            // 
            // lblEtkilesim
            // 
            lblEtkilesim.AutoSize = true;
            lblEtkilesim.Location = new Point(223, 111);
            lblEtkilesim.Name = "lblEtkilesim";
            lblEtkilesim.Size = new Size(68, 20);
            lblEtkilesim.TabIndex = 6;
            lblEtkilesim.Text = "Etkileşim";
            // 
            // txtEtkilesim
            // 
            txtEtkilesim.Location = new Point(354, 111);
            txtEtkilesim.Name = "txtEtkilesim";
            txtEtkilesim.Size = new Size(125, 27);
            txtEtkilesim.TabIndex = 7;
            // 
            // btnDugumEkle
            // 
            btnDugumEkle.Location = new Point(277, 153);
            btnDugumEkle.Name = "btnDugumEkle";
            btnDugumEkle.Size = new Size(123, 29);
            btnDugumEkle.TabIndex = 8;
            btnDugumEkle.Text = "Düğüm Ekle";
            btnDugumEkle.UseVisualStyleBackColor = true;
            btnDugumEkle.Click += btnDugumEkle_Click;
            // 
            // btnDugumGuncelle
            // 
            btnDugumGuncelle.Location = new Point(271, 188);
            btnDugumGuncelle.Name = "btnDugumGuncelle";
            btnDugumGuncelle.Size = new Size(136, 29);
            btnDugumGuncelle.TabIndex = 9;
            btnDugumGuncelle.Text = "Düğüm Güncelle";
            btnDugumGuncelle.UseVisualStyleBackColor = true;
            btnDugumGuncelle.Click += btnDugumGuncelle_Click;
            // 
            // btnDugumSil
            // 
            btnDugumSil.Location = new Point(270, 223);
            btnDugumSil.Name = "btnDugumSil";
            btnDugumSil.Size = new Size(136, 29);
            btnDugumSil.TabIndex = 10;
            btnDugumSil.Text = "Düğüm Sil";
            btnDugumSil.UseVisualStyleBackColor = true;
            btnDugumSil.Click += btnDugumSil_Click;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(12, 9);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(91, 20);
            lblFrom.TabIndex = 11;
            lblFrom.Text = "Başlangıç ID";
            lblFrom.Click += lblFrom_Click;
            // 
            // txtBaslangicId
            // 
            txtBaslangicId.Location = new Point(12, 32);
            txtBaslangicId.Name = "txtBaslangicId";
            txtBaslangicId.Size = new Size(125, 27);
            txtBaslangicId.TabIndex = 12;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(12, 62);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(56, 20);
            lblTo.TabIndex = 13;
            lblTo.Text = "Bitiş ID";
            // 
            // txtBitisId
            // 
            txtBitisId.Location = new Point(12, 85);
            txtBitisId.Name = "txtBitisId";
            txtBitisId.Size = new Size(125, 27);
            txtBitisId.TabIndex = 14;
            // 
            // btnKenarEkle
            // 
            btnKenarEkle.Location = new Point(12, 118);
            btnKenarEkle.Name = "btnKenarEkle";
            btnKenarEkle.Size = new Size(94, 29);
            btnKenarEkle.TabIndex = 15;
            btnKenarEkle.Text = "Kenar Ekle";
            btnKenarEkle.UseVisualStyleBackColor = true;
            btnKenarEkle.Click += btnKenarEkle_Click;
            // 
            // btnKenarSil
            // 
            btnKenarSil.Location = new Point(12, 153);
            btnKenarSil.Name = "btnKenarSil";
            btnKenarSil.Size = new Size(94, 29);
            btnKenarSil.TabIndex = 16;
            btnKenarSil.Text = "Kenar Sil";
            btnKenarSil.UseVisualStyleBackColor = true;
            btnKenarSil.Click += btnKenarSil_Click;
            // 
            // btnKomsulukListele
            // 
            btnKomsulukListele.Location = new Point(12, 333);
            btnKomsulukListele.Name = "btnKomsulukListele";
            btnKomsulukListele.Size = new Size(125, 29);
            btnKomsulukListele.TabIndex = 17;
            btnKomsulukListele.Text = "Komşuluk Listesi";
            btnKomsulukListele.UseVisualStyleBackColor = true;
            btnKomsulukListele.Click += btnKomsulukListele_Click;
            // 
            // rtbCikti
            // 
            rtbCikti.Location = new Point(12, 368);
            rtbCikti.Name = "rtbCikti";
            rtbCikti.Size = new Size(141, 120);
            rtbCikti.TabIndex = 18;
            rtbCikti.Text = "";
            // 
            // btnJsonKaydet
            // 
            btnJsonKaydet.Location = new Point(835, 420);
            btnJsonKaydet.Name = "btnJsonKaydet";
            btnJsonKaydet.Size = new Size(128, 29);
            btnJsonKaydet.TabIndex = 19;
            btnJsonKaydet.Text = "JSON Kaydett";
            btnJsonKaydet.UseVisualStyleBackColor = true;
            btnJsonKaydet.Click += btnJsonKaydet_Click;
            // 
            // btnJsonYukle
            // 
            btnJsonYukle.Location = new Point(835, 459);
            btnJsonYukle.Name = "btnJsonYukle";
            btnJsonYukle.Size = new Size(128, 29);
            btnJsonYukle.TabIndex = 20;
            btnJsonYukle.Text = "JSON Yükle";
            btnJsonYukle.UseVisualStyleBackColor = true;
            btnJsonYukle.Click += btnJsonYukle_Click;
            // 
            // pnlCanvas
            // 
            pnlCanvas.BackColor = Color.White;
            pnlCanvas.BorderStyle = BorderStyle.FixedSingle;
            pnlCanvas.Location = new Point(713, 12);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(250, 205);
            pnlCanvas.TabIndex = 21;
            pnlCanvas.Paint += pnlCanvas_Paint;
            pnlCanvas.MouseClick += pnlCanvas_MouseClick;
            // 
            // grpDugumBilgi
            // 
            grpDugumBilgi.Controls.Add(lblSeciliDugumBilgi);
            grpDugumBilgi.Location = new Point(270, 294);
            grpDugumBilgi.Name = "grpDugumBilgi";
            grpDugumBilgi.Size = new Size(144, 164);
            grpDugumBilgi.TabIndex = 22;
            grpDugumBilgi.TabStop = false;
            grpDugumBilgi.Text = "Düğüm Bilgisi";
            // 
            // lblSeciliDugumBilgi
            // 
            lblSeciliDugumBilgi.AutoSize = true;
            lblSeciliDugumBilgi.Location = new Point(6, 38);
            lblSeciliDugumBilgi.Name = "lblSeciliDugumBilgi";
            lblSeciliDugumBilgi.Size = new Size(124, 20);
            lblSeciliDugumBilgi.TabIndex = 0;
            lblSeciliDugumBilgi.Text = "Seçili Düğüm Yok";
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 500);
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
    }
}
