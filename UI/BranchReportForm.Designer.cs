namespace UI
{
    partial class BranchReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbSubeSec = new ComboBox();
            grpSubeRaporu = new GroupBox();
            btnPDFKaydet = new Button();
            lblDersEgitmenOrtalamasi = new Label();
            lblTextVerilenDersEgitmenOrtalamasi = new Label();
            lblVerilenDersSaati = new Label();
            lblTextVerilenDersSaati = new Label();
            lblEgitimSayisi = new Label();
            lblOgrenciSayisi = new Label();
            lblTextEgitimSayisi = new Label();
            lblEgitmenSayisi = new Label();
            lblTextOgrenciSayisi = new Label();
            lblKoordinatorSayisi = new Label();
            lblTextEgitmenSayisi = new Label();
            lblTextKoordinatorSayisi = new Label();
            grpSubeRaporu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 0;
            label1.Text = "Şube Seç :";
            // 
            // cmbSubeSec
            // 
            cmbSubeSec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubeSec.DropDownWidth = 260;
            cmbSubeSec.FormattingEnabled = true;
            cmbSubeSec.Location = new Point(20, 49);
            cmbSubeSec.Name = "cmbSubeSec";
            cmbSubeSec.Size = new Size(267, 29);
            cmbSubeSec.TabIndex = 1;
            cmbSubeSec.SelectedIndexChanged += cmbSubeSec_SelectedIndexChanged;
            // 
            // grpSubeRaporu
            // 
            grpSubeRaporu.Controls.Add(btnPDFKaydet);
            grpSubeRaporu.Controls.Add(lblDersEgitmenOrtalamasi);
            grpSubeRaporu.Controls.Add(lblTextVerilenDersEgitmenOrtalamasi);
            grpSubeRaporu.Controls.Add(lblVerilenDersSaati);
            grpSubeRaporu.Controls.Add(lblTextVerilenDersSaati);
            grpSubeRaporu.Controls.Add(lblEgitimSayisi);
            grpSubeRaporu.Controls.Add(lblOgrenciSayisi);
            grpSubeRaporu.Controls.Add(lblTextEgitimSayisi);
            grpSubeRaporu.Controls.Add(lblEgitmenSayisi);
            grpSubeRaporu.Controls.Add(lblTextOgrenciSayisi);
            grpSubeRaporu.Controls.Add(lblKoordinatorSayisi);
            grpSubeRaporu.Controls.Add(lblTextEgitmenSayisi);
            grpSubeRaporu.Controls.Add(lblTextKoordinatorSayisi);
            grpSubeRaporu.Location = new Point(20, 94);
            grpSubeRaporu.Name = "grpSubeRaporu";
            grpSubeRaporu.Size = new Size(267, 303);
            grpSubeRaporu.TabIndex = 2;
            grpSubeRaporu.TabStop = false;
            grpSubeRaporu.Text = "Şube Raporu";
            // 
            // btnPDFKaydet
            // 
            btnPDFKaydet.Image = Properties.Resources.PDF_icon2;
            btnPDFKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnPDFKaydet.Location = new Point(12, 229);
            btnPDFKaydet.Name = "btnPDFKaydet";
            btnPDFKaydet.Size = new Size(243, 62);
            btnPDFKaydet.TabIndex = 1;
            btnPDFKaydet.Text = "PDF OLARAK KAYDET";
            btnPDFKaydet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPDFKaydet.UseVisualStyleBackColor = true;
            btnPDFKaydet.Click += btnPDFKaydet_Click;
            // 
            // lblDersEgitmenOrtalamasi
            // 
            lblDersEgitmenOrtalamasi.AutoSize = true;
            lblDersEgitmenOrtalamasi.Location = new Point(190, 183);
            lblDersEgitmenOrtalamasi.Name = "lblDersEgitmenOrtalamasi";
            lblDersEgitmenOrtalamasi.Size = new Size(45, 21);
            lblDersEgitmenOrtalamasi.TabIndex = 0;
            lblDersEgitmenOrtalamasi.Tag = "CleaningIsRequired";
            lblDersEgitmenOrtalamasi.Text = "?????";
            // 
            // lblTextVerilenDersEgitmenOrtalamasi
            // 
            lblTextVerilenDersEgitmenOrtalamasi.Location = new Point(6, 172);
            lblTextVerilenDersEgitmenOrtalamasi.Name = "lblTextVerilenDersEgitmenOrtalamasi";
            lblTextVerilenDersEgitmenOrtalamasi.Size = new Size(161, 48);
            lblTextVerilenDersEgitmenOrtalamasi.TabIndex = 0;
            lblTextVerilenDersEgitmenOrtalamasi.Text = "Verilen Ders/Eğitmen Ortalaması:";
            lblTextVerilenDersEgitmenOrtalamasi.TextAlign = ContentAlignment.TopRight;
            // 
            // lblVerilenDersSaati
            // 
            lblVerilenDersSaati.AutoSize = true;
            lblVerilenDersSaati.Location = new Point(190, 143);
            lblVerilenDersSaati.Name = "lblVerilenDersSaati";
            lblVerilenDersSaati.Size = new Size(45, 21);
            lblVerilenDersSaati.TabIndex = 0;
            lblVerilenDersSaati.Tag = "CleaningIsRequired";
            lblVerilenDersSaati.Text = "?????";
            // 
            // lblTextVerilenDersSaati
            // 
            lblTextVerilenDersSaati.AutoSize = true;
            lblTextVerilenDersSaati.Location = new Point(32, 143);
            lblTextVerilenDersSaati.Name = "lblTextVerilenDersSaati";
            lblTextVerilenDersSaati.Size = new Size(135, 21);
            lblTextVerilenDersSaati.TabIndex = 0;
            lblTextVerilenDersSaati.Text = "Verilen Ders Saati:";
            // 
            // lblEgitimSayisi
            // 
            lblEgitimSayisi.AutoSize = true;
            lblEgitimSayisi.Location = new Point(190, 114);
            lblEgitimSayisi.Name = "lblEgitimSayisi";
            lblEgitimSayisi.Size = new Size(45, 21);
            lblEgitimSayisi.TabIndex = 0;
            lblEgitimSayisi.Tag = "CleaningIsRequired";
            lblEgitimSayisi.Text = "?????";
            // 
            // lblOgrenciSayisi
            // 
            lblOgrenciSayisi.AutoSize = true;
            lblOgrenciSayisi.Location = new Point(190, 85);
            lblOgrenciSayisi.Name = "lblOgrenciSayisi";
            lblOgrenciSayisi.Size = new Size(45, 21);
            lblOgrenciSayisi.TabIndex = 0;
            lblOgrenciSayisi.Tag = "CleaningIsRequired";
            lblOgrenciSayisi.Text = "?????";
            // 
            // lblTextEgitimSayisi
            // 
            lblTextEgitimSayisi.AutoSize = true;
            lblTextEgitimSayisi.Location = new Point(66, 114);
            lblTextEgitimSayisi.Name = "lblTextEgitimSayisi";
            lblTextEgitimSayisi.Size = new Size(101, 21);
            lblTextEgitimSayisi.TabIndex = 0;
            lblTextEgitimSayisi.Text = "Eğitim Sayısı:";
            // 
            // lblEgitmenSayisi
            // 
            lblEgitmenSayisi.AutoSize = true;
            lblEgitmenSayisi.Location = new Point(190, 56);
            lblEgitmenSayisi.Name = "lblEgitmenSayisi";
            lblEgitmenSayisi.Size = new Size(45, 21);
            lblEgitmenSayisi.TabIndex = 0;
            lblEgitmenSayisi.Tag = "CleaningIsRequired";
            lblEgitmenSayisi.Text = "?????";
            // 
            // lblTextOgrenciSayisi
            // 
            lblTextOgrenciSayisi.AutoSize = true;
            lblTextOgrenciSayisi.Location = new Point(55, 85);
            lblTextOgrenciSayisi.Name = "lblTextOgrenciSayisi";
            lblTextOgrenciSayisi.Size = new Size(112, 21);
            lblTextOgrenciSayisi.TabIndex = 0;
            lblTextOgrenciSayisi.Text = "Öğrenci Sayısı:";
            // 
            // lblKoordinatorSayisi
            // 
            lblKoordinatorSayisi.AutoSize = true;
            lblKoordinatorSayisi.Location = new Point(190, 27);
            lblKoordinatorSayisi.Name = "lblKoordinatorSayisi";
            lblKoordinatorSayisi.Size = new Size(45, 21);
            lblKoordinatorSayisi.TabIndex = 0;
            lblKoordinatorSayisi.Tag = "CleaningIsRequired";
            lblKoordinatorSayisi.Text = "?????";
            // 
            // lblTextEgitmenSayisi
            // 
            lblTextEgitmenSayisi.AutoSize = true;
            lblTextEgitmenSayisi.Location = new Point(53, 56);
            lblTextEgitmenSayisi.Name = "lblTextEgitmenSayisi";
            lblTextEgitmenSayisi.Size = new Size(114, 21);
            lblTextEgitmenSayisi.TabIndex = 0;
            lblTextEgitmenSayisi.Text = "Eğitmen Sayısı:";
            // 
            // lblTextKoordinatorSayisi
            // 
            lblTextKoordinatorSayisi.AutoSize = true;
            lblTextKoordinatorSayisi.Location = new Point(23, 27);
            lblTextKoordinatorSayisi.Name = "lblTextKoordinatorSayisi";
            lblTextKoordinatorSayisi.Size = new Size(144, 21);
            lblTextKoordinatorSayisi.TabIndex = 0;
            lblTextKoordinatorSayisi.Text = "Koordinatör Sayısı :";
            // 
            // BranchReportForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 406);
            Controls.Add(grpSubeRaporu);
            Controls.Add(cmbSubeSec);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "BranchReportForm";
            Text = "SubeRaporForm";
            Load += BranchReportForm_Load;
            grpSubeRaporu.ResumeLayout(false);
            grpSubeRaporu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbSubeSec;
        private GroupBox grpSubeRaporu;
        private Label lblDersEgitmenOrtalamasi;
        private Label lblTextVerilenDersEgitmenOrtalamasi;
        private Label lblVerilenDersSaati;
        private Label lblTextVerilenDersSaati;
        private Label lblEgitimSayisi;
        private Label lblOgrenciSayisi;
        private Label lblTextEgitimSayisi;
        private Label lblEgitmenSayisi;
        private Label lblTextOgrenciSayisi;
        private Label lblKoordinatorSayisi;
        private Label lblTextEgitmenSayisi;
        private Label lblTextKoordinatorSayisi;
        private Button btnPDFKaydet;
    }
}