namespace UI
{
    partial class ClassroomCrudForm
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
            grpSınıfBilgileri = new GroupBox();
            dtpBitisTarihi = new DateTimePicker();
            dtpBaslangicTarihi = new DateTimePicker();
            cmbEgitim = new ComboBox();
            cmbEgitmen = new ComboBox();
            txtSinifKodu = new TextBox();
            lblSubeAdi = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpEgitimBilgileri = new GroupBox();
            numericEgitimSuresi = new NumericUpDown();
            mtxtBitisSaati = new MaskedTextBox();
            mtxtBaslangicsaati = new MaskedTextBox();
            chklistegitimGunleri = new CheckedListBox();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnSinifEkle = new Button();
            btnSinifGuncelle = new Button();
            btnSinifSil = new Button();
            listViewsinifListele = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            grpSınıfBilgileri.SuspendLayout();
            grpEgitimBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericEgitimSuresi).BeginInit();
            SuspendLayout();
            // 
            // grpSınıfBilgileri
            // 
            grpSınıfBilgileri.Controls.Add(dtpBitisTarihi);
            grpSınıfBilgileri.Controls.Add(dtpBaslangicTarihi);
            grpSınıfBilgileri.Controls.Add(cmbEgitim);
            grpSınıfBilgileri.Controls.Add(cmbEgitmen);
            grpSınıfBilgileri.Controls.Add(txtSinifKodu);
            grpSınıfBilgileri.Controls.Add(lblSubeAdi);
            grpSınıfBilgileri.Controls.Add(label6);
            grpSınıfBilgileri.Controls.Add(label5);
            grpSınıfBilgileri.Controls.Add(label4);
            grpSınıfBilgileri.Controls.Add(label3);
            grpSınıfBilgileri.Controls.Add(label2);
            grpSınıfBilgileri.Controls.Add(label1);
            grpSınıfBilgileri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpSınıfBilgileri.Location = new Point(13, 10);
            grpSınıfBilgileri.Name = "grpSınıfBilgileri";
            grpSınıfBilgileri.Size = new Size(372, 252);
            grpSınıfBilgileri.TabIndex = 0;
            grpSınıfBilgileri.TabStop = false;
            grpSınıfBilgileri.Text = "Sınıf Bilgileri";
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.Format = DateTimePickerFormat.Short;
            dtpBitisTarihi.Location = new Point(131, 177);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.RightToLeft = RightToLeft.No;
            dtpBitisTarihi.Size = new Size(235, 29);
            dtpBitisTarihi.TabIndex = 3;
            dtpBitisTarihi.Tag = "Bitiş Tarihi";
            // 
            // dtpBaslangicTarihi
            // 
            dtpBaslangicTarihi.Format = DateTimePickerFormat.Short;
            dtpBaslangicTarihi.Location = new Point(131, 69);
            dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            dtpBaslangicTarihi.Size = new Size(235, 29);
            dtpBaslangicTarihi.TabIndex = 3;
            dtpBaslangicTarihi.Tag = "Başlangıç Tarihi";
            // 
            // cmbEgitim
            // 
            cmbEgitim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEgitim.FormattingEnabled = true;
            cmbEgitim.Location = new Point(131, 141);
            cmbEgitim.Name = "cmbEgitim";
            cmbEgitim.Size = new Size(235, 29);
            cmbEgitim.TabIndex = 2;
            cmbEgitim.Tag = "Eğitim";
            // 
            // cmbEgitmen
            // 
            cmbEgitmen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEgitmen.FormattingEnabled = true;
            cmbEgitmen.Location = new Point(131, 105);
            cmbEgitmen.Name = "cmbEgitmen";
            cmbEgitmen.Size = new Size(235, 29);
            cmbEgitmen.TabIndex = 2;
            cmbEgitmen.Tag = "Eğitmen";
            cmbEgitmen.SelectedIndexChanged += cmbEgitmen_SelectedIndexChanged;
            // 
            // txtSinifKodu
            // 
            txtSinifKodu.Location = new Point(131, 33);
            txtSinifKodu.MaxLength = 15;
            txtSinifKodu.Name = "txtSinifKodu";
            txtSinifKodu.Size = new Size(235, 29);
            txtSinifKodu.TabIndex = 1;
            txtSinifKodu.Tag = "Sınıf Kodu";
            // 
            // lblSubeAdi
            // 
            lblSubeAdi.AutoSize = true;
            lblSubeAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubeAdi.Location = new Point(131, 217);
            lblSubeAdi.Name = "lblSubeAdi";
            lblSubeAdi.Size = new Size(45, 21);
            lblSubeAdi.TabIndex = 0;
            lblSubeAdi.Text = "?????";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(77, 216);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 0;
            label6.Text = "Şube:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 180);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 0;
            label5.Text = "Bitiş Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 144);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 0;
            label4.Text = "Eğitim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 108);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 0;
            label3.Text = "Eğitmen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 75);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 0;
            label2.Text = "Başlangıç Tarihi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 36);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 0;
            label1.Text = "Sınıf Kodu:";
            // 
            // grpEgitimBilgileri
            // 
            grpEgitimBilgileri.Controls.Add(numericEgitimSuresi);
            grpEgitimBilgileri.Controls.Add(mtxtBitisSaati);
            grpEgitimBilgileri.Controls.Add(mtxtBaslangicsaati);
            grpEgitimBilgileri.Controls.Add(chklistegitimGunleri);
            grpEgitimBilgileri.Controls.Add(label11);
            grpEgitimBilgileri.Controls.Add(label9);
            grpEgitimBilgileri.Controls.Add(label8);
            grpEgitimBilgileri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpEgitimBilgileri.Location = new Point(391, 10);
            grpEgitimBilgileri.Name = "grpEgitimBilgileri";
            grpEgitimBilgileri.Size = new Size(306, 252);
            grpEgitimBilgileri.TabIndex = 1;
            grpEgitimBilgileri.TabStop = false;
            grpEgitimBilgileri.Text = "Eğitim Bilgileri";
            // 
            // numericEgitimSuresi
            // 
            numericEgitimSuresi.Location = new Point(158, 120);
            numericEgitimSuresi.Margin = new Padding(8, 11, 8, 11);
            numericEgitimSuresi.Name = "numericEgitimSuresi";
            numericEgitimSuresi.Size = new Size(101, 29);
            numericEgitimSuresi.TabIndex = 3;
            numericEgitimSuresi.Tag = "Eğitim Süresi (Saat/Gün))";
            numericEgitimSuresi.TextAlign = HorizontalAlignment.Center;
            // 
            // mtxtBitisSaati
            // 
            mtxtBitisSaati.Location = new Point(230, 193);
            mtxtBitisSaati.Mask = "00:00";
            mtxtBitisSaati.Name = "mtxtBitisSaati";
            mtxtBitisSaati.Size = new Size(63, 29);
            mtxtBitisSaati.TabIndex = 2;
            mtxtBitisSaati.Tag = "Bitiş Saati";
            mtxtBitisSaati.TextAlign = HorizontalAlignment.Center;
            mtxtBitisSaati.ValidatingType = typeof(DateTime);
            // 
            // mtxtBaslangicsaati
            // 
            mtxtBaslangicsaati.Location = new Point(137, 193);
            mtxtBaslangicsaati.Mask = "00:00";
            mtxtBaslangicsaati.Name = "mtxtBaslangicsaati";
            mtxtBaslangicsaati.Size = new Size(63, 29);
            mtxtBaslangicsaati.TabIndex = 2;
            mtxtBaslangicsaati.Tag = "Başlangıç Saati";
            mtxtBaslangicsaati.TextAlign = HorizontalAlignment.Center;
            mtxtBaslangicsaati.ValidatingType = typeof(DateTime);
            // 
            // chklistegitimGunleri
            // 
            chklistegitimGunleri.FormattingEnabled = true;
            chklistegitimGunleri.Items.AddRange(new object[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" });
            chklistegitimGunleri.Location = new Point(16, 68);
            chklistegitimGunleri.Name = "chklistegitimGunleri";
            chklistegitimGunleri.Size = new Size(109, 172);
            chklistegitimGunleri.TabIndex = 1;
            chklistegitimGunleri.Tag = "Eğitim Günleri";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(137, 160);
            label11.Name = "label11";
            label11.Size = new Size(156, 21);
            label11.TabIndex = 0;
            label11.Text = "Başlangıç - Bitiş Saati";
            // 
            // label9
            // 
            label9.Location = new Point(158, 68);
            label9.Name = "label9";
            label9.Size = new Size(101, 42);
            label9.TabIndex = 0;
            label9.Text = "Eğitim Süresi (Saat/Gün)";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 36);
            label8.Name = "label8";
            label8.Size = new Size(109, 21);
            label8.TabIndex = 0;
            label8.Text = "Eğitim Günleri";
            // 
            // btnSinifEkle
            // 
            btnSinifEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSinifEkle.Location = new Point(13, 270);
            btnSinifEkle.Name = "btnSinifEkle";
            btnSinifEkle.Size = new Size(220, 60);
            btnSinifEkle.TabIndex = 2;
            btnSinifEkle.Text = "SINIF EKLE";
            btnSinifEkle.UseVisualStyleBackColor = true;
            btnSinifEkle.Click += btnSinifEkle_Click;
            // 
            // btnSinifGuncelle
            // 
            btnSinifGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSinifGuncelle.Location = new Point(245, 270);
            btnSinifGuncelle.Name = "btnSinifGuncelle";
            btnSinifGuncelle.Size = new Size(220, 60);
            btnSinifGuncelle.TabIndex = 2;
            btnSinifGuncelle.Text = "SINIF GÜNCELLE";
            btnSinifGuncelle.UseVisualStyleBackColor = true;
            btnSinifGuncelle.Click += btnSinifGuncelle_Click;
            // 
            // btnSinifSil
            // 
            btnSinifSil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSinifSil.Location = new Point(477, 270);
            btnSinifSil.Name = "btnSinifSil";
            btnSinifSil.Size = new Size(220, 60);
            btnSinifSil.TabIndex = 2;
            btnSinifSil.Text = "SINIF SİL";
            btnSinifSil.UseVisualStyleBackColor = true;
            btnSinifSil.Click += btnSinifSil_Click;
            // 
            // listViewsinifListele
            // 
            listViewsinifListele.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewsinifListele.GridLines = true;
            listViewsinifListele.Location = new Point(13, 336);
            listViewsinifListele.Name = "listViewsinifListele";
            listViewsinifListele.Size = new Size(688, 282);
            listViewsinifListele.TabIndex = 3;
            listViewsinifListele.UseCompatibleStateImageBehavior = false;
            listViewsinifListele.View = View.Details;
            listViewsinifListele.SelectedIndexChanged += listViewsinifListele_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Sınıf Kodu";
            columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Eğitim";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 137;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Başlangıç Tarihi";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 137;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Bitiş Tarihi";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 137;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Eğitmen";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 137;
            // 
            // ClassroomCrudForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 626);
            Controls.Add(listViewsinifListele);
            Controls.Add(btnSinifSil);
            Controls.Add(btnSinifGuncelle);
            Controls.Add(btnSinifEkle);
            Controls.Add(grpEgitimBilgileri);
            Controls.Add(grpSınıfBilgileri);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(725, 665);
            MinimumSize = new Size(725, 665);
            Name = "ClassroomCrudForm";
            Text = "SınıfEkleGüncelleSilForm";
            Load += ClassroomCrudForm_Load;
            grpSınıfBilgileri.ResumeLayout(false);
            grpSınıfBilgileri.PerformLayout();
            grpEgitimBilgileri.ResumeLayout(false);
            grpEgitimBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericEgitimSuresi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpSınıfBilgileri;
        private GroupBox grpEgitimBilgileri;
        private Button btnSinifEkle;
        private Button btnSinifGuncelle;
        private Button btnSinifSil;
        private ListView listViewsinifListele;
        private ComboBox comboBox4;
        private ComboBox cmbEgitim;
        private ComboBox cmbEgitmen;
        private ComboBox comboBox1;
        private TextBox txtSinifKodu;
        private Label lblSubeAdi;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label11;
        private Label label9;
        private Label label8;
        private MaskedTextBox mtxtBitisSaati;
        private MaskedTextBox mtxtBaslangicsaati;
        private CheckedListBox chklistegitimGunleri;
        private NumericUpDown numericEgitimSuresi;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private DateTimePicker dtpBitisTarihi;
        private DateTimePicker dtpBaslangicTarihi;
    }
}