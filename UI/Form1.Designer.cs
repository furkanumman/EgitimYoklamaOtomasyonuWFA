namespace UI
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnGirisYap = new Button();
            chkBoxParolayiGöster = new CheckBox();
            lblSifre = new Label();
            lblMailAdresi = new Label();
            txtSifre = new TextBox();
            txtMailAdresi = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGirisYap);
            groupBox1.Controls.Add(chkBoxParolayiGöster);
            groupBox1.Controls.Add(lblSifre);
            groupBox1.Controls.Add(lblMailAdresi);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(txtMailAdresi);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 210);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "GİRİŞ PANELİ";
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(112, 146);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(206, 56);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // chkBoxParolayiGöster
            // 
            chkBoxParolayiGöster.AutoSize = true;
            chkBoxParolayiGöster.Location = new Point(112, 115);
            chkBoxParolayiGöster.Name = "chkBoxParolayiGöster";
            chkBoxParolayiGöster.Size = new Size(134, 25);
            chkBoxParolayiGöster.TabIndex = 2;
            chkBoxParolayiGöster.Text = "Parolayı Göster";
            chkBoxParolayiGöster.UseVisualStyleBackColor = true;
            chkBoxParolayiGöster.CheckedChanged += chkBoxParolayiGöster_CheckedChanged;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(61, 83);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(45, 21);
            lblSifre.TabIndex = 3;
            lblSifre.Text = "Şifre:";
            // 
            // lblMailAdresi
            // 
            lblMailAdresi.AutoSize = true;
            lblMailAdresi.Location = new Point(15, 43);
            lblMailAdresi.Name = "lblMailAdresi";
            lblMailAdresi.Size = new Size(91, 21);
            lblMailAdresi.TabIndex = 2;
            lblMailAdresi.Text = "Mail Adresi:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(112, 80);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(206, 29);
            txtSifre.TabIndex = 1;
            // 
            // txtMailAdresi
            // 
            txtMailAdresi.Location = new Point(112, 40);
            txtMailAdresi.Name = "txtMailAdresi";
            txtMailAdresi.Size = new Size(206, 29);
            txtMailAdresi.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 231);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(370, 270);
            MinimizeBox = false;
            MinimumSize = new Size(370, 270);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnGirisYap;
        private CheckBox chkBoxParolayiGöster;
        private Label lblSifre;
        private Label lblMailAdresi;
        private TextBox txtSifre;
        private TextBox txtMailAdresi;
    }
}