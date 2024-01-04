namespace UI
{
    partial class EducationCrudForm
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
            grpBoxEgitimBilgileri = new GroupBox();
            btnEgitimGuncelle = new Button();
            btnEgitimSil = new Button();
            btnEgitimEkle = new Button();
            label4 = new Label();
            nudEgitimSuresi = new NumericUpDown();
            txtAciklama = new TextBox();
            txtEgitimAdi = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listViewEgitimBilgileri = new ListView();
            columnEgitimAdi = new ColumnHeader();
            columnEgitimSuresi = new ColumnHeader();
            columnAciklama = new ColumnHeader();
            grpBoxEgitimBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEgitimSuresi).BeginInit();
            SuspendLayout();
            // 
            // grpBoxEgitimBilgileri
            // 
            grpBoxEgitimBilgileri.Controls.Add(btnEgitimGuncelle);
            grpBoxEgitimBilgileri.Controls.Add(btnEgitimSil);
            grpBoxEgitimBilgileri.Controls.Add(btnEgitimEkle);
            grpBoxEgitimBilgileri.Controls.Add(label4);
            grpBoxEgitimBilgileri.Controls.Add(nudEgitimSuresi);
            grpBoxEgitimBilgileri.Controls.Add(txtAciklama);
            grpBoxEgitimBilgileri.Controls.Add(txtEgitimAdi);
            grpBoxEgitimBilgileri.Controls.Add(label3);
            grpBoxEgitimBilgileri.Controls.Add(label2);
            grpBoxEgitimBilgileri.Controls.Add(label1);
            grpBoxEgitimBilgileri.Location = new Point(13, 12);
            grpBoxEgitimBilgileri.Name = "grpBoxEgitimBilgileri";
            grpBoxEgitimBilgileri.Size = new Size(682, 189);
            grpBoxEgitimBilgileri.TabIndex = 0;
            grpBoxEgitimBilgileri.TabStop = false;
            grpBoxEgitimBilgileri.Text = "Eğitim Bilgileri";
            // 
            // btnEgitimGuncelle
            // 
            btnEgitimGuncelle.Location = new Point(472, 112);
            btnEgitimGuncelle.Name = "btnEgitimGuncelle";
            btnEgitimGuncelle.Size = new Size(91, 68);
            btnEgitimGuncelle.TabIndex = 4;
            btnEgitimGuncelle.Text = "Eğitim\r\nGüncelle";
            btnEgitimGuncelle.UseVisualStyleBackColor = true;
            btnEgitimGuncelle.Click += btnEgitimGuncelle_Click;
            // 
            // btnEgitimSil
            // 
            btnEgitimSil.Location = new Point(576, 112);
            btnEgitimSil.Name = "btnEgitimSil";
            btnEgitimSil.Size = new Size(91, 68);
            btnEgitimSil.TabIndex = 4;
            btnEgitimSil.Text = "Eğitim\r\nSil";
            btnEgitimSil.UseVisualStyleBackColor = true;
            btnEgitimSil.Click += btnEgitimSil_Click;
            // 
            // btnEgitimEkle
            // 
            btnEgitimEkle.Location = new Point(368, 112);
            btnEgitimEkle.Name = "btnEgitimEkle";
            btnEgitimEkle.Size = new Size(91, 68);
            btnEgitimEkle.TabIndex = 4;
            btnEgitimEkle.Text = "Eğitim\r\nEkle";
            btnEgitimEkle.UseVisualStyleBackColor = true;
            btnEgitimEkle.Click += btnEgitimEkle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 79);
            label4.Name = "label4";
            label4.Size = new Size(38, 21);
            label4.TabIndex = 3;
            label4.Text = "saat";
            // 
            // nudEgitimSuresi
            // 
            nudEgitimSuresi.Location = new Point(114, 77);
            nudEgitimSuresi.Margin = new Padding(4);
            nudEgitimSuresi.Maximum = new decimal(new int[] { 750, 0, 0, 0 });
            nudEgitimSuresi.Name = "nudEgitimSuresi";
            nudEgitimSuresi.Size = new Size(88, 29);
            nudEgitimSuresi.TabIndex = 2;
            nudEgitimSuresi.Tag = "Eğitim Süresi";
            nudEgitimSuresi.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(368, 37);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(300, 69);
            txtAciklama.TabIndex = 1;
            txtAciklama.Tag = "Açıklama";
            // 
            // txtEgitimAdi
            // 
            txtEgitimAdi.Location = new Point(113, 37);
            txtEgitimAdi.Name = "txtEgitimAdi";
            txtEgitimAdi.Size = new Size(153, 29);
            txtEgitimAdi.TabIndex = 1;
            txtEgitimAdi.Tag = "Eğitim Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 40);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 0;
            label3.Text = "Açıklama:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 79);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 0;
            label2.Text = "Eğitim Süresi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 40);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 0;
            label1.Text = "Eğitim Adı:";
            // 
            // listViewEgitimBilgileri
            // 
            listViewEgitimBilgileri.Columns.AddRange(new ColumnHeader[] { columnEgitimAdi, columnEgitimSuresi, columnAciklama });
            listViewEgitimBilgileri.GridLines = true;
            listViewEgitimBilgileri.Location = new Point(12, 207);
            listViewEgitimBilgileri.Name = "listViewEgitimBilgileri";
            listViewEgitimBilgileri.Size = new Size(683, 407);
            listViewEgitimBilgileri.TabIndex = 1;
            listViewEgitimBilgileri.UseCompatibleStateImageBehavior = false;
            listViewEgitimBilgileri.View = View.Details;
            listViewEgitimBilgileri.SelectedIndexChanged += listViewEgitimBilgileri_SelectedIndexChanged;
            // 
            // columnEgitimAdi
            // 
            columnEgitimAdi.Text = "Eğitim Adı";
            columnEgitimAdi.Width = 120;
            // 
            // columnEgitimSuresi
            // 
            columnEgitimSuresi.Text = "Eğitim Süresi";
            columnEgitimSuresi.Width = 110;
            // 
            // columnAciklama
            // 
            columnAciklama.Text = "Açıklama";
            columnAciklama.Width = 450;
            // 
            // EducationCrudForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 626);
            Controls.Add(listViewEgitimBilgileri);
            Controls.Add(grpBoxEgitimBilgileri);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "EducationCrudForm";
            Text = "EgitimEkleGuncelleSilForm";
            Load += EgitimIslemForm_Load;
            grpBoxEgitimBilgileri.ResumeLayout(false);
            grpBoxEgitimBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEgitimSuresi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxEgitimBilgileri;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private NumericUpDown nudEgitimSuresi;
        private TextBox txtAciklama;
        private TextBox txtEgitimAdi;
        private Button btnEgitimGuncelle;
        private Button btnEgitimSil;
        private Button btnEgitimEkle;
        private ListView listViewEgitimBilgileri;
        private ColumnHeader columnEgitimAdi;
        private ColumnHeader columnEgitimSuresi;
        private ColumnHeader columnAciklama;
    }
}