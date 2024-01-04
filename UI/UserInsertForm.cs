using BLL.Services;
using DATA;
using DATA.Enums;
using PasswordGenerator;


namespace UI
{
    public partial class UserInsertForm : Form
    {
        AdministratorService administratorService;
        CoordinatorService coordinatorService;
        EducatorService educatorService;
        BranchService branchService;

        string? dosyaYolu = null;

        public UserInsertForm()
        {
            InitializeComponent();
        }

        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            administratorService = new AdministratorService();
            coordinatorService = new CoordinatorService();
            educatorService = new EducatorService();
            branchService = new BranchService();

            cmbBoxGorevi.Items.AddRange(Enum.GetNames(typeof(Role)));
            SubeleriListele();
            txtParola.PasswordChar = '*';
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdResimSec = new OpenFileDialog();
            ofdResimSec.Title = "Resim Seç";
            ofdResimSec.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            ofdResimSec.Multiselect = false;
            ofdResimSec.ShowDialog();
            dosyaYolu = ofdResimSec.FileName;
            pBoxResim.ImageLocation = dosyaYolu;
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            bool kontrolKullaniciBilgileri = ComponentControl.BlankControl(grpBoxKullaniciBilgileri);

            bool kontrolUyelikBilgileri = ComponentControl.BlankControl(grpBoxUyelikBilgileri);

            bool kontrolDogumTarihi = true;
            if (dtpDogumTarihi.Value > DateTime.Now)
            {
                MessageBox.Show("Doğum tarihini kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kontrolDogumTarihi = false;
            }

            bool kontrolEMail = true;
            if (administratorService.CheckControl(x => x.Email == txtMailAdresi.Text) || coordinatorService.CheckControl(x => x.Email == txtMailAdresi.Text) || educatorService.CheckControl(x => x.Email == txtMailAdresi.Text))
            {
                MessageBox.Show("Mail adresi kullanılmaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw new Exception("Mail adresi kullanılmaktadır!");
                kontrolEMail = false;
            }

            bool kontrol = kontrolKullaniciBilgileri && kontrolUyelikBilgileri && kontrolDogumTarihi && kontrolEMail;

            if (Enum.GetName(typeof(Role), 0) == cmbBoxGorevi.Text && kontrol)
            {
                MessageBox.Show("Kullanıcı ekleme yapabilir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Administrator administrator = new Administrator()
                {
                    Name = txtAd.Text,
                    Surname = txtSoyad.Text,
                    DateofBirth = dtpDogumTarihi.Value.Date,
                    Phone = mTxtCepTelefonu.Text,
                    Role = Role.Yonetici,
                    Photo = dosyaYolu,
                    Email = txtMailAdresi.Text,
                    Password = txtParola.Text
                };
                administratorService.Insert(administrator);
                MessageBox.Show("Yönetici eklenmiştir!");
                ComponentControl.ControlClean(grpBoxKullaniciBilgileri);
                ComponentControl.ControlClean(grpBoxUyelikBilgileri);
            }

            else if (Enum.GetName(typeof(Role), 1) == cmbBoxGorevi.Text && kontrol)
            {
                Coordinator coordinator = new Coordinator()
                {
                    Name = txtAd.Text,
                    Surname = txtSoyad.Text,
                    DateofBirth = dtpDogumTarihi.Value.Date,
                    Phone = mTxtCepTelefonu.Text,
                    Role = Role.Koordinator,
                    Photo = dosyaYolu,
                    Email = txtMailAdresi.Text,
                    Password = txtParola.Text,
                    IsActive = true,
                    BranchID = branchService.GetBranchIDByName(cmbBoxSube.Text) == -1 ? null : branchService.GetBranchIDByName(cmbBoxSube.Text)
                };
                coordinatorService.Insert(coordinator);
                MessageBox.Show("Koordinatör eklenmiştir!");
                ComponentControl.ControlClean(grpBoxKullaniciBilgileri);
                ComponentControl.ControlClean(grpBoxUyelikBilgileri);
            }


            else if (Enum.GetName(typeof(Role), 2) == cmbBoxGorevi.Text && kontrol)
            {
                Educator educator = new Educator()
                {
                    Name = txtAd.Text,
                    Surname = txtSoyad.Text,
                    DateofBirth = dtpDogumTarihi.Value.Date,
                    Phone = mTxtCepTelefonu.Text,
                    Role = Role.Egitmen,
                    Photo = dosyaYolu,
                    Email = txtMailAdresi.Text,
                    Password = txtParola.Text,
                    IsActive = true,
                    BranchID = branchService.GetBranchIDByName(cmbBoxSube.Text) == -1 ? null : branchService.GetBranchIDByName(cmbBoxSube.Text)
                    //BranchID = branchService.GetBranchIDByName(cmbBoxSube.Text)
                };
                if (cmbBoxSube.SelectedIndex != -1)
                {
                    educatorService.Insert(educator);
                    MessageBox.Show("Eğitmen eklenmiştir!");
                    ComponentControl.ControlClean(grpBoxKullaniciBilgileri);
                    ComponentControl.ControlClean(grpBoxUyelikBilgileri);
                }
                else
                {
                    MessageBox.Show("Lütfen bir şube seçiniz..");
                }
            }

            else
            {
                MessageBox.Show("Ekleme yapılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void SubeleriListele()
        {
            List<Branch> branches = branchService.GetAll();

            foreach (Branch branch in branches)
            {
                cmbBoxSube.Items.Add($"{branch.Name}");
            }
        }

        private void chkBoxParolaOtomatikOlustur_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxParolaOtomatikOlustur.Checked)
            {
                txtParola.PasswordChar = '\0';
                Password passwordGenerator = new Password();
                string password1 = passwordGenerator.Next();
                txtParola.Text = password1;
            }
            else
            {
                txtParola.Text = string.Empty;
            }
        }
    }
}
