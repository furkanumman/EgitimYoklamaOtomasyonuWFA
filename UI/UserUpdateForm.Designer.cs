namespace UI
{
    partial class UserUpdateForm
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
            grpBoxKullaniciBilgileri = new GroupBox();
            btnResimSec = new Button();
            pBoxResim = new PictureBox();
            cmbBoxSube = new ComboBox();
            cmbBoxGorevi = new ComboBox();
            mTxtCepTelefonu = new MaskedTextBox();
            dtpDogumTarihi = new DateTimePicker();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpBoxUyelikBilgileri = new GroupBox();
            chkBoxParolaOtomatikOlustur = new CheckBox();
            txtParola = new TextBox();
            txtMailAdresi = new TextBox();
            label8 = new Label();
            label7 = new Label();
            grpBoxArama = new GroupBox();
            txtAdaSoyadaGoreArama = new TextBox();
            cmbBoxGoreviArama = new ComboBox();
            btnAramaYap = new Button();
            label10 = new Label();
            label9 = new Label();
            listViewKullanici = new ListView();
            columnAdi = new ColumnHeader();
            columnSoyadi = new ColumnHeader();
            columnCepTelefonu = new ColumnHeader();
            columnMailAdresi = new ColumnHeader();
            columnGorevi = new ColumnHeader();
            columnSube = new ColumnHeader();
            btnKullaniciGuncelle = new Button();
            btnKullaniciSil = new Button();
            grpBoxKullaniciBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxResim).BeginInit();
            grpBoxUyelikBilgileri.SuspendLayout();
            grpBoxArama.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxKullaniciBilgileri
            // 
            grpBoxKullaniciBilgileri.Controls.Add(btnResimSec);
            grpBoxKullaniciBilgileri.Controls.Add(pBoxResim);
            grpBoxKullaniciBilgileri.Controls.Add(cmbBoxSube);
            grpBoxKullaniciBilgileri.Controls.Add(cmbBoxGorevi);
            grpBoxKullaniciBilgileri.Controls.Add(mTxtCepTelefonu);
            grpBoxKullaniciBilgileri.Controls.Add(dtpDogumTarihi);
            grpBoxKullaniciBilgileri.Controls.Add(txtSoyad);
            grpBoxKullaniciBilgileri.Controls.Add(txtAd);
            grpBoxKullaniciBilgileri.Controls.Add(label6);
            grpBoxKullaniciBilgileri.Controls.Add(label5);
            grpBoxKullaniciBilgileri.Controls.Add(label4);
            grpBoxKullaniciBilgileri.Controls.Add(label3);
            grpBoxKullaniciBilgileri.Controls.Add(label2);
            grpBoxKullaniciBilgileri.Controls.Add(label1);
            grpBoxKullaniciBilgileri.Location = new Point(12, 13);
            grpBoxKullaniciBilgileri.Name = "grpBoxKullaniciBilgileri";
            grpBoxKullaniciBilgileri.Size = new Size(437, 263);
            grpBoxKullaniciBilgileri.TabIndex = 1;
            grpBoxKullaniciBilgileri.TabStop = false;
            grpBoxKullaniciBilgileri.Text = "Kullanıcı Bilgileri";
            // 
            // btnResimSec
            // 
            btnResimSec.Location = new Point(289, 184);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(133, 67);
            btnResimSec.TabIndex = 7;
            btnResimSec.Text = "Resim Seç";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.Click += btnResimSec_Click;
            // 
            // pBoxResim
            // 
            pBoxResim.BorderStyle = BorderStyle.FixedSingle;
            pBoxResim.Location = new Point(289, 28);
            pBoxResim.Name = "pBoxResim";
            pBoxResim.Size = new Size(133, 146);
            pBoxResim.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxResim.TabIndex = 6;
            pBoxResim.TabStop = false;
            // 
            // cmbBoxSube
            // 
            cmbBoxSube.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxSube.FormattingEnabled = true;
            cmbBoxSube.Location = new Point(116, 223);
            cmbBoxSube.Name = "cmbBoxSube";
            cmbBoxSube.Size = new Size(150, 29);
            cmbBoxSube.TabIndex = 5;
            cmbBoxSube.Tag = "Şubesi";
            // 
            // cmbBoxGorevi
            // 
            cmbBoxGorevi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxGorevi.FormattingEnabled = true;
            cmbBoxGorevi.Location = new Point(116, 184);
            cmbBoxGorevi.Name = "cmbBoxGorevi";
            cmbBoxGorevi.Size = new Size(150, 29);
            cmbBoxGorevi.TabIndex = 4;
            cmbBoxGorevi.Tag = "Görevi";
            // 
            // mTxtCepTelefonu
            // 
            mTxtCepTelefonu.Location = new Point(115, 145);
            mTxtCepTelefonu.Mask = "(999) 000-0000";
            mTxtCepTelefonu.Name = "mTxtCepTelefonu";
            mTxtCepTelefonu.Size = new Size(150, 29);
            mTxtCepTelefonu.TabIndex = 3;
            mTxtCepTelefonu.Tag = "CepTelefonu";
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(115, 106);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(150, 29);
            dtpDogumTarihi.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(115, 67);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(150, 29);
            txtSoyad.TabIndex = 1;
            txtSoyad.Tag = "Soyadı";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(115, 28);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(150, 29);
            txtAd.TabIndex = 0;
            txtAd.Tag = "Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 226);
            label6.Name = "label6";
            label6.Size = new Size(56, 21);
            label6.TabIndex = 0;
            label6.Text = "Şubesi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 187);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 0;
            label5.Text = "Görevi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 148);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 0;
            label4.Text = "Cep Telefonu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 112);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 0;
            label3.Text = "Doğum Tarihi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 70);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 0;
            label2.Text = "Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 31);
            label1.Name = "label1";
            label1.Size = new Size(36, 21);
            label1.TabIndex = 0;
            label1.Text = "Adı:";
            // 
            // grpBoxUyelikBilgileri
            // 
            grpBoxUyelikBilgileri.Controls.Add(chkBoxParolaOtomatikOlustur);
            grpBoxUyelikBilgileri.Controls.Add(txtParola);
            grpBoxUyelikBilgileri.Controls.Add(txtMailAdresi);
            grpBoxUyelikBilgileri.Controls.Add(label8);
            grpBoxUyelikBilgileri.Controls.Add(label7);
            grpBoxUyelikBilgileri.Location = new Point(455, 13);
            grpBoxUyelikBilgileri.Name = "grpBoxUyelikBilgileri";
            grpBoxUyelikBilgileri.Size = new Size(362, 144);
            grpBoxUyelikBilgileri.TabIndex = 2;
            grpBoxUyelikBilgileri.TabStop = false;
            grpBoxUyelikBilgileri.Text = "Üyelik Bilgileri";
            // 
            // chkBoxParolaOtomatikOlustur
            // 
            chkBoxParolaOtomatikOlustur.AutoSize = true;
            chkBoxParolaOtomatikOlustur.Location = new Point(138, 108);
            chkBoxParolaOtomatikOlustur.Name = "chkBoxParolaOtomatikOlustur";
            chkBoxParolaOtomatikOlustur.RightToLeft = RightToLeft.Yes;
            chkBoxParolaOtomatikOlustur.Size = new Size(209, 25);
            chkBoxParolaOtomatikOlustur.TabIndex = 10;
            chkBoxParolaOtomatikOlustur.Text = "Parolayı Otomatik Oluştur";
            chkBoxParolaOtomatikOlustur.UseVisualStyleBackColor = true;
            chkBoxParolaOtomatikOlustur.CheckedChanged += chkBoxParolaOtomatikOlustur_CheckedChanged;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(107, 67);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(240, 29);
            txtParola.TabIndex = 9;
            txtParola.Tag = "Parola";
            // 
            // txtMailAdresi
            // 
            txtMailAdresi.Location = new Point(107, 28);
            txtMailAdresi.Name = "txtMailAdresi";
            txtMailAdresi.Size = new Size(240, 29);
            txtMailAdresi.TabIndex = 9;
            txtMailAdresi.Tag = "MailAdresi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 70);
            label8.Name = "label8";
            label8.Size = new Size(56, 21);
            label8.TabIndex = 8;
            label8.Text = "Parola:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 31);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 8;
            label7.Text = "Mail Adresi:";
            // 
            // grpBoxArama
            // 
            grpBoxArama.Controls.Add(txtAdaSoyadaGoreArama);
            grpBoxArama.Controls.Add(cmbBoxGoreviArama);
            grpBoxArama.Controls.Add(btnAramaYap);
            grpBoxArama.Controls.Add(label10);
            grpBoxArama.Controls.Add(label9);
            grpBoxArama.Location = new Point(12, 285);
            grpBoxArama.Name = "grpBoxArama";
            grpBoxArama.Size = new Size(805, 71);
            grpBoxArama.TabIndex = 3;
            grpBoxArama.TabStop = false;
            grpBoxArama.Text = "Arama";
            // 
            // txtAdaSoyadaGoreArama
            // 
            txtAdaSoyadaGoreArama.Location = new Point(149, 27);
            txtAdaSoyadaGoreArama.Name = "txtAdaSoyadaGoreArama";
            txtAdaSoyadaGoreArama.Size = new Size(191, 29);
            txtAdaSoyadaGoreArama.TabIndex = 8;
            txtAdaSoyadaGoreArama.Tag = "Adı";
            // 
            // cmbBoxGoreviArama
            // 
            cmbBoxGoreviArama.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxGoreviArama.FormattingEnabled = true;
            cmbBoxGoreviArama.Location = new Point(453, 27);
            cmbBoxGoreviArama.Name = "cmbBoxGoreviArama";
            cmbBoxGoreviArama.Size = new Size(150, 29);
            cmbBoxGoreviArama.TabIndex = 5;
            cmbBoxGoreviArama.Tag = "Görevi";
            // 
            // btnAramaYap
            // 
            btnAramaYap.Location = new Point(626, 22);
            btnAramaYap.Name = "btnAramaYap";
            btnAramaYap.Size = new Size(164, 37);
            btnAramaYap.TabIndex = 3;
            btnAramaYap.Text = "Arama Yap";
            btnAramaYap.UseVisualStyleBackColor = true;
            btnAramaYap.Click += btnAramaYap_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(346, 30);
            label10.Name = "label10";
            label10.Size = new Size(101, 21);
            label10.TabIndex = 2;
            label10.Text = "Göreve Göre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 30);
            label9.Name = "label9";
            label9.Size = new Size(135, 21);
            label9.TabIndex = 1;
            label9.Text = "Ada/Soyada Göre:";
            // 
            // listViewKullanici
            // 
            listViewKullanici.Columns.AddRange(new ColumnHeader[] { columnAdi, columnSoyadi, columnCepTelefonu, columnMailAdresi, columnGorevi, columnSube });
            listViewKullanici.GridLines = true;
            listViewKullanici.Location = new Point(12, 362);
            listViewKullanici.Name = "listViewKullanici";
            listViewKullanici.Size = new Size(805, 304);
            listViewKullanici.TabIndex = 4;
            listViewKullanici.UseCompatibleStateImageBehavior = false;
            listViewKullanici.View = View.Details;
            listViewKullanici.SelectedIndexChanged += listViewKullanici_SelectedIndexChanged;
            // 
            // columnAdi
            // 
            columnAdi.Text = "Adı";
            columnAdi.Width = 150;
            // 
            // columnSoyadi
            // 
            columnSoyadi.Text = "Soyadı";
            columnSoyadi.Width = 150;
            // 
            // columnCepTelefonu
            // 
            columnCepTelefonu.Text = "Cep Telefonu";
            columnCepTelefonu.Width = 150;
            // 
            // columnMailAdresi
            // 
            columnMailAdresi.Text = "Mail Adresi";
            columnMailAdresi.Width = 150;
            // 
            // columnGorevi
            // 
            columnGorevi.Text = "Gorevi";
            columnGorevi.Width = 100;
            // 
            // columnSube
            // 
            columnSube.Text = "Şubesi";
            columnSube.Width = 100;
            // 
            // btnKullaniciGuncelle
            // 
            btnKullaniciGuncelle.Location = new Point(455, 163);
            btnKullaniciGuncelle.Name = "btnKullaniciGuncelle";
            btnKullaniciGuncelle.Size = new Size(165, 113);
            btnKullaniciGuncelle.TabIndex = 5;
            btnKullaniciGuncelle.Text = "KULLANICI GÜNCELLE";
            btnKullaniciGuncelle.UseVisualStyleBackColor = true;
            btnKullaniciGuncelle.Click += btnKullaniciGuncelle_Click;
            // 
            // btnKullaniciSil
            // 
            btnKullaniciSil.Location = new Point(652, 163);
            btnKullaniciSil.Name = "btnKullaniciSil";
            btnKullaniciSil.Size = new Size(165, 113);
            btnKullaniciSil.TabIndex = 6;
            btnKullaniciSil.Text = "KULLANICI SİL";
            btnKullaniciSil.UseVisualStyleBackColor = true;
            btnKullaniciSil.Click += btnKullaniciSil_Click;
            // 
            // UserUpdateForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 678);
            Controls.Add(btnKullaniciSil);
            Controls.Add(btnKullaniciGuncelle);
            Controls.Add(listViewKullanici);
            Controls.Add(grpBoxArama);
            Controls.Add(grpBoxUyelikBilgileri);
            Controls.Add(grpBoxKullaniciBilgileri);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UserUpdateForm";
            Text = "KullaniciGuncelleForm";
            Load += KullaniciGuncelleForm_Load;
            grpBoxKullaniciBilgileri.ResumeLayout(false);
            grpBoxKullaniciBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxResim).EndInit();
            grpBoxUyelikBilgileri.ResumeLayout(false);
            grpBoxUyelikBilgileri.PerformLayout();
            grpBoxArama.ResumeLayout(false);
            grpBoxArama.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxKullaniciBilgileri;
        private Button btnResimSec;
        private PictureBox pBoxResim;
        private ComboBox cmbBoxSube;
        private ComboBox cmbBoxGorevi;
        private MaskedTextBox mTxtCepTelefonu;
        private DateTimePicker dtpDogumTarihi;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grpBoxUyelikBilgileri;
        private CheckBox chkBoxParolaOtomatikOlustur;
        private TextBox txtParola;
        private TextBox txtMailAdresi;
        private Label label8;
        private Label label7;
        private GroupBox grpBoxArama;
        private TextBox txtAdaSoyadaGoreArama;
        private ComboBox cmbBoxGoreviArama;
        private Button btnAramaYap;
        private Label label10;
        private Label label9;
        private ListView listViewKullanici;
        private Button btnKullaniciGuncelle;
        private Button btnKullaniciSil;
        private ColumnHeader columnAdi;
        private ColumnHeader columnSoyadi;
        private ColumnHeader columnCepTelefonu;
        private ColumnHeader columnMailAdresi;
        private ColumnHeader columnGorevi;
        private ColumnHeader columnSube;
    }
}