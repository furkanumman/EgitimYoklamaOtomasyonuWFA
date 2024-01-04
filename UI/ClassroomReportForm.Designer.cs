namespace UI
{
    partial class ClassroomReportForm
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
            btnFiltrele = new Button();
            lblSubeSec = new Label();
            lblSinifSec = new Label();
            cmbSubeSec = new ComboBox();
            cmbSinifSec = new ComboBox();
            grpBoxSinifRaporu = new GroupBox();
            listViewSubeRaporBilgileri = new ListView();
            columnHeaderSiraNo = new ColumnHeader();
            columnHeaderOgrenciAdSoyad = new ColumnHeader();
            columnHeaderKatildigiDersSaati = new ColumnHeader();
            columnHeaderDevamOrani = new ColumnHeader();
            lblEgitmen = new Label();
            lblKalanDersSaati = new Label();
            lblTextEgitmen = new Label();
            lblOgrenciSayisi = new Label();
            lblTextKalanDersSaati = new Label();
            lblTextOgrenciSayisi = new Label();
            lblYapilanDersSaati = new Label();
            lblTextYapilanDersSaati = new Label();
            btnPDFKaydet = new Button();
            grpBoxSinifRaporu.SuspendLayout();
            SuspendLayout();
            // 
            // btnFiltrele
            // 
            btnFiltrele.Location = new Point(330, 32);
            btnFiltrele.Margin = new Padding(3, 4, 3, 4);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(169, 73);
            btnFiltrele.TabIndex = 0;
            btnFiltrele.Text = "Filtrele";
            btnFiltrele.UseVisualStyleBackColor = true;
            btnFiltrele.Click += btnFiltrele_Click;
            // 
            // lblSubeSec
            // 
            lblSubeSec.AutoSize = true;
            lblSubeSec.Location = new Point(35, 35);
            lblSubeSec.Name = "lblSubeSec";
            lblSubeSec.Size = new Size(76, 21);
            lblSubeSec.TabIndex = 1;
            lblSubeSec.Text = "Şube Seç:";
            // 
            // lblSinifSec
            // 
            lblSinifSec.AutoSize = true;
            lblSinifSec.Location = new Point(39, 79);
            lblSinifSec.Name = "lblSinifSec";
            lblSinifSec.Size = new Size(72, 21);
            lblSinifSec.TabIndex = 1;
            lblSinifSec.Text = "Sınıf Seç:";
            // 
            // cmbSubeSec
            // 
            cmbSubeSec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubeSec.FormattingEnabled = true;
            cmbSubeSec.Location = new Point(117, 32);
            cmbSubeSec.Name = "cmbSubeSec";
            cmbSubeSec.Size = new Size(188, 29);
            cmbSubeSec.TabIndex = 2;
            cmbSubeSec.SelectedIndexChanged += cmbSubeSec_SelectedIndexChanged;
            // 
            // cmbSinifSec
            // 
            cmbSinifSec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSinifSec.FormattingEnabled = true;
            cmbSinifSec.Location = new Point(117, 76);
            cmbSinifSec.Name = "cmbSinifSec";
            cmbSinifSec.Size = new Size(188, 29);
            cmbSinifSec.TabIndex = 2;
            // 
            // grpBoxSinifRaporu
            // 
            grpBoxSinifRaporu.Controls.Add(listViewSubeRaporBilgileri);
            grpBoxSinifRaporu.Controls.Add(lblEgitmen);
            grpBoxSinifRaporu.Controls.Add(lblKalanDersSaati);
            grpBoxSinifRaporu.Controls.Add(lblTextEgitmen);
            grpBoxSinifRaporu.Controls.Add(lblOgrenciSayisi);
            grpBoxSinifRaporu.Controls.Add(lblTextKalanDersSaati);
            grpBoxSinifRaporu.Controls.Add(lblTextOgrenciSayisi);
            grpBoxSinifRaporu.Controls.Add(lblYapilanDersSaati);
            grpBoxSinifRaporu.Controls.Add(lblTextYapilanDersSaati);
            grpBoxSinifRaporu.Controls.Add(btnPDFKaydet);
            grpBoxSinifRaporu.Location = new Point(12, 129);
            grpBoxSinifRaporu.Name = "grpBoxSinifRaporu";
            grpBoxSinifRaporu.Size = new Size(681, 519);
            grpBoxSinifRaporu.TabIndex = 3;
            grpBoxSinifRaporu.TabStop = false;
            grpBoxSinifRaporu.Text = "Sınıf Raporu";
            // 
            // listViewSubeRaporBilgileri
            // 
            listViewSubeRaporBilgileri.Columns.AddRange(new ColumnHeader[] { columnHeaderSiraNo, columnHeaderOgrenciAdSoyad, columnHeaderKatildigiDersSaati, columnHeaderDevamOrani });
            listViewSubeRaporBilgileri.Location = new Point(6, 117);
            listViewSubeRaporBilgileri.Name = "listViewSubeRaporBilgileri";
            listViewSubeRaporBilgileri.Size = new Size(664, 396);
            listViewSubeRaporBilgileri.TabIndex = 4;
            listViewSubeRaporBilgileri.UseCompatibleStateImageBehavior = false;
            listViewSubeRaporBilgileri.View = View.Details;
            // 
            // columnHeaderSiraNo
            // 
            columnHeaderSiraNo.Text = "Sıra No";
            columnHeaderSiraNo.Width = 75;
            // 
            // columnHeaderOgrenciAdSoyad
            // 
            columnHeaderOgrenciAdSoyad.Text = "Öğrenci Adı Soyadı";
            columnHeaderOgrenciAdSoyad.Width = 250;
            // 
            // columnHeaderKatildigiDersSaati
            // 
            columnHeaderKatildigiDersSaati.Text = "Katıldığı Ders Saati";
            columnHeaderKatildigiDersSaati.Width = 175;
            // 
            // columnHeaderDevamOrani
            // 
            columnHeaderDevamOrani.Text = "Devam Oranı (%)";
            columnHeaderDevamOrani.Width = 160;
            // 
            // lblEgitmen
            // 
            lblEgitmen.AutoSize = true;
            lblEgitmen.Location = new Point(377, 83);
            lblEgitmen.Name = "lblEgitmen";
            lblEgitmen.Size = new Size(45, 21);
            lblEgitmen.TabIndex = 3;
            lblEgitmen.Text = "?????";
            // 
            // lblKalanDersSaati
            // 
            lblKalanDersSaati.AutoSize = true;
            lblKalanDersSaati.Location = new Point(174, 83);
            lblKalanDersSaati.Name = "lblKalanDersSaati";
            lblKalanDersSaati.Size = new Size(45, 21);
            lblKalanDersSaati.TabIndex = 3;
            lblKalanDersSaati.Text = "?????";
            // 
            // lblTextEgitmen
            // 
            lblTextEgitmen.AutoSize = true;
            lblTextEgitmen.Location = new Point(297, 83);
            lblTextEgitmen.Name = "lblTextEgitmen";
            lblTextEgitmen.Size = new Size(70, 21);
            lblTextEgitmen.TabIndex = 3;
            lblTextEgitmen.Text = "Eğitmen:";
            // 
            // lblOgrenciSayisi
            // 
            lblOgrenciSayisi.AutoSize = true;
            lblOgrenciSayisi.Location = new Point(377, 25);
            lblOgrenciSayisi.Name = "lblOgrenciSayisi";
            lblOgrenciSayisi.Size = new Size(45, 21);
            lblOgrenciSayisi.TabIndex = 3;
            lblOgrenciSayisi.Text = "?????";
            // 
            // lblTextKalanDersSaati
            // 
            lblTextKalanDersSaati.AutoSize = true;
            lblTextKalanDersSaati.Location = new Point(39, 83);
            lblTextKalanDersSaati.Name = "lblTextKalanDersSaati";
            lblTextKalanDersSaati.Size = new Size(125, 21);
            lblTextKalanDersSaati.TabIndex = 3;
            lblTextKalanDersSaati.Text = "Kalan Ders Saati:";
            // 
            // lblTextOgrenciSayisi
            // 
            lblTextOgrenciSayisi.AutoSize = true;
            lblTextOgrenciSayisi.Location = new Point(255, 25);
            lblTextOgrenciSayisi.Name = "lblTextOgrenciSayisi";
            lblTextOgrenciSayisi.Size = new Size(112, 21);
            lblTextOgrenciSayisi.TabIndex = 3;
            lblTextOgrenciSayisi.Text = "Öğrenci Sayısı:";
            // 
            // lblYapilanDersSaati
            // 
            lblYapilanDersSaati.AutoSize = true;
            lblYapilanDersSaati.Location = new Point(174, 25);
            lblYapilanDersSaati.Name = "lblYapilanDersSaati";
            lblYapilanDersSaati.Size = new Size(45, 21);
            lblYapilanDersSaati.TabIndex = 3;
            lblYapilanDersSaati.Text = "?????";
            // 
            // lblTextYapilanDersSaati
            // 
            lblTextYapilanDersSaati.AutoSize = true;
            lblTextYapilanDersSaati.Location = new Point(27, 25);
            lblTextYapilanDersSaati.Name = "lblTextYapilanDersSaati";
            lblTextYapilanDersSaati.Size = new Size(137, 21);
            lblTextYapilanDersSaati.TabIndex = 3;
            lblTextYapilanDersSaati.Text = "Yapılan Ders Saati:";
            // 
            // btnPDFKaydet
            // 
            btnPDFKaydet.Image = Properties.Resources.PDF_icon2;
            btnPDFKaydet.ImageAlign = ContentAlignment.MiddleLeft;
            btnPDFKaydet.Location = new Point(493, 25);
            btnPDFKaydet.Name = "btnPDFKaydet";
            btnPDFKaydet.Size = new Size(177, 79);
            btnPDFKaydet.TabIndex = 2;
            btnPDFKaydet.Text = "PDF OLARAK KAYDET";
            btnPDFKaydet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPDFKaydet.UseVisualStyleBackColor = true;
            btnPDFKaydet.Click += btnPDFKaydet_Click;
            // 
            // ClassroomReportForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 653);
            Controls.Add(grpBoxSinifRaporu);
            Controls.Add(cmbSinifSec);
            Controls.Add(cmbSubeSec);
            Controls.Add(lblSinifSec);
            Controls.Add(lblSubeSec);
            Controls.Add(btnFiltrele);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ClassroomReportForm";
            Text = "ClassroomReportForm";
            Load += ClassroomReportForm_Load;
            grpBoxSinifRaporu.ResumeLayout(false);
            grpBoxSinifRaporu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFiltrele;
        private Label lblSubeSec;
        private Label lblSinifSec;
        private ComboBox cmbSubeSec;
        private ComboBox cmbSinifSec;
        private GroupBox grpBoxSinifRaporu;
        private Label lblKalanDersSaati;
        private Label lblTextKalanDersSaati;
        private Label lblYapilanDersSaati;
        private Label lblTextYapilanDersSaati;
        private Button btnPDFKaydet;
        private ListView listViewSubeRaporBilgileri;
        private ColumnHeader columnHeaderSiraNo;
        private ColumnHeader columnHeaderOgrenciAdSoyad;
        private ColumnHeader columnHeaderKatildigiDersSaati;
        private ColumnHeader columnHeaderDevamOrani;
        private Label lblEgitmen;
        private Label lblTextEgitmen;
        private Label lblOgrenciSayisi;
        private Label lblTextOgrenciSayisi;
    }
}