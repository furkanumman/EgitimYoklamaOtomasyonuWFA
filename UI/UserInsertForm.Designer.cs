namespace UI
{
    partial class UserInsertForm
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
            grpBoxUyelikBilgileri = new GroupBox();
            chkBoxParolaOtomatikOlustur = new CheckBox();
            txtParola = new TextBox();
            txtMailAdresi = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btnKullaniciEkle = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            dtpDogumTarihi = new DateTimePicker();
            mTxtCepTelefonu = new MaskedTextBox();
            cmbBoxGorevi = new ComboBox();
            cmbBoxSube = new ComboBox();
            pBoxResim = new PictureBox();
            btnResimSec = new Button();
            grpBoxKullaniciBilgileri = new GroupBox();
            grpBoxUyelikBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxResim).BeginInit();
            grpBoxKullaniciBilgileri.SuspendLayout();
            SuspendLayout();
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
            grpBoxUyelikBilgileri.TabIndex = 1;
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
            // btnKullaniciEkle
            // 
            btnKullaniciEkle.Location = new Point(455, 164);
            btnKullaniciEkle.Name = "btnKullaniciEkle";
            btnKullaniciEkle.Size = new Size(362, 112);
            btnKullaniciEkle.TabIndex = 2;
            btnKullaniciEkle.Text = "KULLANICI EKLE";
            btnKullaniciEkle.UseVisualStyleBackColor = true;
            btnKullaniciEkle.Click += btnKullaniciEkle_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 70);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 0;
            label2.Text = "Soyadı:";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 148);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 0;
            label4.Text = "Cep Telefonu:";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 226);
            label6.Name = "label6";
            label6.Size = new Size(56, 21);
            label6.TabIndex = 0;
            label6.Text = "Şubesi";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(115, 28);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(150, 29);
            txtAd.TabIndex = 0;
            txtAd.Tag = "Adı";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(115, 67);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(150, 29);
            txtSoyad.TabIndex = 1;
            txtSoyad.Tag = "Soyadı";
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(115, 106);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(150, 29);
            dtpDogumTarihi.TabIndex = 2;
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
            grpBoxKullaniciBilgileri.TabIndex = 0;
            grpBoxKullaniciBilgileri.TabStop = false;
            grpBoxKullaniciBilgileri.Text = "Kullanıcı Bilgileri";
            // 
            // KullaniciEkleForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 291);
            Controls.Add(btnKullaniciEkle);
            Controls.Add(grpBoxUyelikBilgileri);
            Controls.Add(grpBoxKullaniciBilgileri);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(845, 330);
            MinimumSize = new Size(845, 330);
            Name = "KullaniciEkleForm";
            Text = "KullaniciEkleForm";
            Load += KullaniciEkleForm_Load;
            grpBoxUyelikBilgileri.ResumeLayout(false);
            grpBoxUyelikBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxResim).EndInit();
            grpBoxKullaniciBilgileri.ResumeLayout(false);
            grpBoxKullaniciBilgileri.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpBoxUyelikBilgileri;
        private CheckBox chkBoxParolaOtomatikOlustur;
        private TextBox txtParola;
        private TextBox txtMailAdresi;
        private Label label8;
        private Label label7;
        private Button btnKullaniciEkle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private DateTimePicker dtpDogumTarihi;
        private MaskedTextBox mTxtCepTelefonu;
        private ComboBox cmbBoxGorevi;
        private ComboBox cmbBoxSube;
        private PictureBox pBoxResim;
        private Button btnResimSec;
        private GroupBox grpBoxKullaniciBilgileri;
    }
}