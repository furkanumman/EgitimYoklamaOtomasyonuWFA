namespace UI
{
    partial class BranchCrudForm
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
            grpBoxSubeBilgileri = new GroupBox();
            mtbTelefon = new MaskedTextBox();
            cmbBoxKoordinator = new ComboBox();
            txtAdres = new TextBox();
            txtMail = new TextBox();
            txtSubeAdi = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSubeGuncelle = new Button();
            btnSubeSil = new Button();
            btnSubeEkle = new Button();
            listViewSubeBilgileri = new ListView();
            columnSubeAdi = new ColumnHeader();
            columnSubeKoordinatoru = new ColumnHeader();
            columnSubeMail = new ColumnHeader();
            columnSubeTelefon = new ColumnHeader();
            grpBoxSubeBilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxSubeBilgileri
            // 
            grpBoxSubeBilgileri.Controls.Add(mtbTelefon);
            grpBoxSubeBilgileri.Controls.Add(cmbBoxKoordinator);
            grpBoxSubeBilgileri.Controls.Add(txtAdres);
            grpBoxSubeBilgileri.Controls.Add(txtMail);
            grpBoxSubeBilgileri.Controls.Add(txtSubeAdi);
            grpBoxSubeBilgileri.Controls.Add(label3);
            grpBoxSubeBilgileri.Controls.Add(label5);
            grpBoxSubeBilgileri.Controls.Add(label4);
            grpBoxSubeBilgileri.Controls.Add(label2);
            grpBoxSubeBilgileri.Controls.Add(label1);
            grpBoxSubeBilgileri.Location = new Point(12, 12);
            grpBoxSubeBilgileri.Name = "grpBoxSubeBilgileri";
            grpBoxSubeBilgileri.Size = new Size(770, 210);
            grpBoxSubeBilgileri.TabIndex = 0;
            grpBoxSubeBilgileri.TabStop = false;
            grpBoxSubeBilgileri.Text = "Şube Bilgileri";
            // 
            // mtbTelefon
            // 
            mtbTelefon.Location = new Point(147, 166);
            mtbTelefon.Mask = "(999) 000-0000";
            mtbTelefon.Name = "mtbTelefon";
            mtbTelefon.Size = new Size(200, 29);
            mtbTelefon.TabIndex = 5;
            mtbTelefon.Tag = "Şube Telefonu";
            // 
            // cmbBoxKoordinator
            // 
            cmbBoxKoordinator.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxKoordinator.FormattingEnabled = true;
            cmbBoxKoordinator.Location = new Point(147, 80);
            cmbBoxKoordinator.Name = "cmbBoxKoordinator";
            cmbBoxKoordinator.Size = new Size(200, 29);
            cmbBoxKoordinator.TabIndex = 1;
            cmbBoxKoordinator.Tag = "Şube Koordinatörü";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(484, 36);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(271, 159);
            txtAdres.TabIndex = 4;
            txtAdres.Tag = "Şube Adresi";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(147, 123);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(200, 29);
            txtMail.TabIndex = 2;
            txtMail.Tag = "Şube Mail";
            // 
            // txtSubeAdi
            // 
            txtSubeAdi.Location = new Point(147, 37);
            txtSubeAdi.Name = "txtSubeAdi";
            txtSubeAdi.Size = new Size(200, 29);
            txtSubeAdi.TabIndex = 0;
            txtSubeAdi.Tag = "Şube Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 39);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 0;
            label3.Text = "Şube Adresi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 169);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 0;
            label5.Text = "Şube Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 126);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 0;
            label4.Text = "Şube Mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 83);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 0;
            label2.Text = "Şube Koordinatör:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 40);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 0;
            label1.Text = "Şube Adı:";
            // 
            // btnSubeGuncelle
            // 
            btnSubeGuncelle.Location = new Point(277, 228);
            btnSubeGuncelle.Name = "btnSubeGuncelle";
            btnSubeGuncelle.Size = new Size(240, 50);
            btnSubeGuncelle.TabIndex = 6;
            btnSubeGuncelle.Text = "ŞUBE GÜNCELLE";
            btnSubeGuncelle.UseVisualStyleBackColor = true;
            btnSubeGuncelle.Click += btnSubeGuncelle_Click;
            // 
            // btnSubeSil
            // 
            btnSubeSil.Location = new Point(542, 228);
            btnSubeSil.Name = "btnSubeSil";
            btnSubeSil.Size = new Size(240, 50);
            btnSubeSil.TabIndex = 7;
            btnSubeSil.Text = "ŞUBE SİL";
            btnSubeSil.UseVisualStyleBackColor = true;
            btnSubeSil.Click += btnSubeSil_Click;
            // 
            // btnSubeEkle
            // 
            btnSubeEkle.Location = new Point(12, 228);
            btnSubeEkle.Name = "btnSubeEkle";
            btnSubeEkle.Size = new Size(240, 50);
            btnSubeEkle.TabIndex = 5;
            btnSubeEkle.Text = "ŞUBE EKLE";
            btnSubeEkle.UseVisualStyleBackColor = true;
            btnSubeEkle.Click += btnSubeEkle_Click;
            // 
            // listViewSubeBilgileri
            // 
            listViewSubeBilgileri.Columns.AddRange(new ColumnHeader[] { columnSubeAdi, columnSubeKoordinatoru, columnSubeMail, columnSubeTelefon });
            listViewSubeBilgileri.Location = new Point(12, 284);
            listViewSubeBilgileri.Name = "listViewSubeBilgileri";
            listViewSubeBilgileri.Size = new Size(770, 365);
            listViewSubeBilgileri.TabIndex = 5;
            listViewSubeBilgileri.UseCompatibleStateImageBehavior = false;
            listViewSubeBilgileri.View = View.Details;
            listViewSubeBilgileri.SelectedIndexChanged += listViewSubeBilgileri_SelectedIndexChanged;
            // 
            // columnSubeAdi
            // 
            columnSubeAdi.Text = "Şube Adı";
            columnSubeAdi.Width = 205;
            // 
            // columnSubeKoordinatoru
            // 
            columnSubeKoordinatoru.Text = "Şube Koordinatörü";
            columnSubeKoordinatoru.Width = 200;
            // 
            // columnSubeMail
            // 
            columnSubeMail.Text = "Şube Mail";
            columnSubeMail.Width = 200;
            // 
            // columnSubeTelefon
            // 
            columnSubeTelefon.Text = "Şube Telefon";
            columnSubeTelefon.Width = 160;
            // 
            // SubeIslemForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 661);
            Controls.Add(listViewSubeBilgileri);
            Controls.Add(btnSubeGuncelle);
            Controls.Add(grpBoxSubeBilgileri);
            Controls.Add(btnSubeSil);
            Controls.Add(btnSubeEkle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "SubeIslemForm";
            Text = "SubeEkleGuncelleSilForm";
            Load += SubeIslemForm_Load;
            grpBoxSubeBilgileri.ResumeLayout(false);
            grpBoxSubeBilgileri.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxSubeBilgileri;
        private ComboBox cmbBoxKoordinator;
        private TextBox txtAdres;
        private TextBox txtMail;
        private TextBox txtSubeAdi;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnSubeGuncelle;
        private Button btnSubeSil;
        private Button btnSubeEkle;
        private ListView listViewSubeBilgileri;
        private ColumnHeader columnSubeAdi;
        private ColumnHeader columnSubeKoordinatoru;
        private ColumnHeader columnSubeMail;
        private ColumnHeader columnSubeTelefon;
        private MaskedTextBox mtbTelefon;
    }
}