namespace UI
{
    partial class AttendanceForm
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
            grpBoxYoklamaBul = new GroupBox();
            btnYoklamaBul = new Button();
            dtpYoklamaTarihi = new DateTimePicker();
            cmbSinif = new ComboBox();
            lblTarih = new Label();
            lblSube = new Label();
            lblSinif = new Label();
            lblTextSube = new Label();
            btnTumOgrencileriSec = new Button();
            btnHicSecme = new Button();
            btnYoklamaGir = new Button();
            grpBoxYoklamaBul.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxYoklamaBul
            // 
            grpBoxYoklamaBul.Controls.Add(btnYoklamaBul);
            grpBoxYoklamaBul.Controls.Add(dtpYoklamaTarihi);
            grpBoxYoklamaBul.Controls.Add(cmbSinif);
            grpBoxYoklamaBul.Controls.Add(lblTarih);
            grpBoxYoklamaBul.Controls.Add(lblSube);
            grpBoxYoklamaBul.Controls.Add(lblSinif);
            grpBoxYoklamaBul.Controls.Add(lblTextSube);
            grpBoxYoklamaBul.Location = new Point(13, 13);
            grpBoxYoklamaBul.Margin = new Padding(4);
            grpBoxYoklamaBul.Name = "grpBoxYoklamaBul";
            grpBoxYoklamaBul.Padding = new Padding(4);
            grpBoxYoklamaBul.Size = new Size(809, 119);
            grpBoxYoklamaBul.TabIndex = 0;
            grpBoxYoklamaBul.TabStop = false;
            grpBoxYoklamaBul.Text = "Yoklama Bul";
            // 
            // btnYoklamaBul
            // 
            btnYoklamaBul.Location = new Point(650, 40);
            btnYoklamaBul.Name = "btnYoklamaBul";
            btnYoklamaBul.Size = new Size(147, 65);
            btnYoklamaBul.TabIndex = 3;
            btnYoklamaBul.Text = "Yoklama Bul";
            btnYoklamaBul.UseVisualStyleBackColor = true;
            btnYoklamaBul.Click += btnYoklamaBul_Click;
            // 
            // dtpYoklamaTarihi
            // 
            dtpYoklamaTarihi.Location = new Point(400, 76);
            dtpYoklamaTarihi.Name = "dtpYoklamaTarihi";
            dtpYoklamaTarihi.Size = new Size(224, 29);
            dtpYoklamaTarihi.TabIndex = 2;
            dtpYoklamaTarihi.ValueChanged += dtpYoklamaTarihi_ValueChanged;
            // 
            // cmbSinif
            // 
            cmbSinif.FormattingEnabled = true;
            cmbSinif.Location = new Point(200, 76);
            cmbSinif.Name = "cmbSinif";
            cmbSinif.Size = new Size(180, 29);
            cmbSinif.TabIndex = 1;
            cmbSinif.SelectedIndexChanged += cmbSinif_SelectedIndexChanged;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(400, 40);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(46, 21);
            lblTarih.TabIndex = 0;
            lblTarih.Text = "Tarih:";
            // 
            // lblSube
            // 
            lblSube.AutoSize = true;
            lblSube.Location = new Point(20, 80);
            lblSube.Name = "lblSube";
            lblSube.Size = new Size(45, 21);
            lblSube.TabIndex = 0;
            lblSube.Text = "?????";
            // 
            // lblSinif
            // 
            lblSinif.AutoSize = true;
            lblSinif.Location = new Point(200, 40);
            lblSinif.Name = "lblSinif";
            lblSinif.Size = new Size(44, 21);
            lblSinif.TabIndex = 0;
            lblSinif.Text = "Sınıf:";
            // 
            // lblTextSube
            // 
            lblTextSube.AutoSize = true;
            lblTextSube.Location = new Point(20, 40);
            lblTextSube.Name = "lblTextSube";
            lblTextSube.Size = new Size(48, 21);
            lblTextSube.TabIndex = 0;
            lblTextSube.Text = "Şube:";
            // 
            // btnTumOgrencileriSec
            // 
            btnTumOgrencileriSec.Location = new Point(12, 634);
            btnTumOgrencileriSec.Name = "btnTumOgrencileriSec";
            btnTumOgrencileriSec.Size = new Size(187, 65);
            btnTumOgrencileriSec.TabIndex = 1;
            btnTumOgrencileriSec.Text = "TÜM ÖĞRENCİLERİ SEÇ";
            btnTumOgrencileriSec.UseVisualStyleBackColor = true;
            btnTumOgrencileriSec.Click += btnTumOgrencileriSec_Click;
            // 
            // btnHicSecme
            // 
            btnHicSecme.Location = new Point(206, 634);
            btnHicSecme.Name = "btnHicSecme";
            btnHicSecme.Size = new Size(187, 65);
            btnHicSecme.TabIndex = 1;
            btnHicSecme.Text = "HİÇBİRİNİ SEÇME";
            btnHicSecme.UseVisualStyleBackColor = true;
            btnHicSecme.Click += btnHicSecme_Click;
            // 
            // btnYoklamaGir
            // 
            btnYoklamaGir.Location = new Point(610, 634);
            btnYoklamaGir.Name = "btnYoklamaGir";
            btnYoklamaGir.Size = new Size(212, 65);
            btnYoklamaGir.TabIndex = 1;
            btnYoklamaGir.Text = "YOKLAMA GİR";
            btnYoklamaGir.UseVisualStyleBackColor = true;
            btnYoklamaGir.Click += btnYoklamaGir_Click;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 711);
            Controls.Add(btnYoklamaGir);
            Controls.Add(btnHicSecme);
            Controls.Add(btnTumOgrencileriSec);
            Controls.Add(grpBoxYoklamaBul);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AttendanceForm";
            Text = "AttendanceForm";
            Load += AttendanceForm_Load;
            grpBoxYoklamaBul.ResumeLayout(false);
            grpBoxYoklamaBul.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxYoklamaBul;
        private Button btnYoklamaBul;
        private DateTimePicker dtpYoklamaTarihi;
        private ComboBox cmbSinif;
        private Label lblTarih;
        private Label lblSube;
        private Label lblSinif;
        private Label lblTextSube;
        private Button btnTumOgrencileriSec;
        private Button btnHicSecme;
        private Button btnYoklamaGir;
    }
}