using BLL.Services;
using DAL.Repositories;
using DATA;
using DATA.Enums;
using PasswordGenerator;

namespace UI
{
    public partial class UserUpdateForm : Form
    {
        AdministratorService administratorService;
        CoordinatorService coordinatorService;
        BranchService branchService;
        EducatorService educatorService;

        string? dosyaYolu = string.Empty;
        Administrator oldAdministrator;
        Coordinator oldCoordinator;
        Educator oldEducator;

        public UserUpdateForm()
        {
            InitializeComponent();
        }

        private void KullaniciGuncelleForm_Load(object sender, EventArgs e)
        {
            administratorService = new AdministratorService();
            coordinatorService = new CoordinatorService();
            educatorService = new EducatorService();
            branchService = new BranchService();

            cmbBoxGorevi.Items.AddRange(Enum.GetNames(typeof(Role)));
            cmbBoxGoreviArama.Items.AddRange(Enum.GetNames(typeof(Role)));
            txtParola.PasswordChar = '*';
            cmbBoxGorevi.Enabled = false;
            txtMailAdresi.Enabled = false;
            SubeleriListele();
        }

        private void btnAramaYap_Click(object sender, EventArgs e)
        {
            listViewKullanici.Items.Clear();
            if (Enum.GetName(typeof(Role), 0) == cmbBoxGoreviArama.Text)
            {
                List<Administrator> administrators = administratorService.Where(x => x.Name == txtAdaSoyadaGoreArama.Text || x.Surname == txtAdaSoyadaGoreArama.Text);
                if (administrators != null)
                {
                    foreach (Administrator administrator in administrators)
                    {
                        ListViewItem listViewItem = new ListViewItem(administrator.Name);
                        listViewItem.SubItems.Add(administrator.Surname);
                        listViewItem.SubItems.Add(administrator.Phone);
                        listViewItem.SubItems.Add(administrator.Email);
                        listViewItem.SubItems.Add(Enum.GetName(typeof(Role), administrator.Role));
                        listViewItem.SubItems.Add("-");
                        listViewKullanici.Items.Add(listViewItem);
                    }
                }
                else
                {
                    return;
                }

            }

            else if (Enum.GetName(typeof(Role), 1) == cmbBoxGoreviArama.Text)
            {
                List<Coordinator> coordinators = coordinatorService.Where(x => x.Name == txtAdaSoyadaGoreArama.Text || x.Surname == txtAdaSoyadaGoreArama.Text);
                if (coordinators != null)
                {
                    foreach (Coordinator coordinator in coordinators)
                    {
                        ListViewItem listViewItem = new ListViewItem(coordinator.Name);
                        listViewItem.SubItems.Add(coordinator.Surname);
                        listViewItem.SubItems.Add(coordinator.Phone);
                        listViewItem.SubItems.Add(coordinator.Email);
                        listViewItem.SubItems.Add(Enum.GetName(typeof(Role), coordinator.Role));
                        listViewItem.SubItems.Add(branchService.GetBranchNameByID(coordinator.BranchID));
                        listViewKullanici.Items.Add(listViewItem);
                    }
                }
                else
                    return;
            }

            else if (Enum.GetName(typeof(Role), 2) == cmbBoxGoreviArama.Text)
            {
                List<Educator> educators = educatorService.Where(x => x.Name == txtAdaSoyadaGoreArama.Text || x.Surname == txtAdaSoyadaGoreArama.Text);
                if (educators != null)
                {
                    foreach (Educator educator in educators)
                    {
                        ListViewItem listViewItem = new ListViewItem(educator.Name);
                        listViewItem.SubItems.Add(educator.Surname);
                        listViewItem.SubItems.Add(educator.Phone);
                        listViewItem.SubItems.Add(educator.Email);
                        listViewItem.SubItems.Add(Enum.GetName(typeof(Role), educator.Role));
                        listViewItem.SubItems.Add(branchService.GetBranchNameByID(educator.BranchID));
                        listViewKullanici.Items.Add(listViewItem);
                    }
                }
                else
                    return;
            }
        }

        private void listViewKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            pBoxResim.Image = null;
            if (listViewKullanici.SelectedItems.Count > 0)
            {
                ListViewItem seciliSatir = listViewKullanici.SelectedItems[0];
                string mailAdresi = seciliSatir.SubItems[3].Text;
                if (Enum.GetName(typeof(Role), 0) == cmbBoxGoreviArama.Text)
                {
                    //oldAdministrator = administratorService.Where(x => x.Email == mailAdresi)[0];
                    oldAdministrator = administratorService.GetByEmailAddress(mailAdresi);
                    if (oldAdministrator != null)
                    {
                        txtAd.Text = oldAdministrator.Name;
                        txtSoyad.Text = oldAdministrator.Surname;
                        dtpDogumTarihi.Value = oldAdministrator.DateofBirth;
                        mTxtCepTelefonu.Text = oldAdministrator.Phone;
                        cmbBoxGorevi.SelectedIndex = (int)oldAdministrator.Role;
                        txtMailAdresi.Text = oldAdministrator.Email;
                        if (!String.IsNullOrEmpty(oldAdministrator.Photo))
                        {
                            pBoxResim.Image = Image.FromFile(oldAdministrator.Photo);
                            dosyaYolu = oldAdministrator.Photo;
                        }
                        else
                            pBoxResim.Image = null;
                        txtParola.Text = oldAdministrator.Password;
                    }
                    else
                        throw new Exception("Kullanıcı bulunamadı!");
                }
                else if (Enum.GetName(typeof(Role), 1) == cmbBoxGoreviArama.Text)
                {
                    oldCoordinator = coordinatorService.GetByEmailAddress(mailAdresi);

                    if (oldCoordinator != null)
                    {
                        txtAd.Text = oldCoordinator.Name;
                        txtSoyad.Text = oldCoordinator.Surname;
                        dtpDogumTarihi.Value = oldCoordinator.DateofBirth;
                        mTxtCepTelefonu.Text = oldCoordinator.Phone;
                        cmbBoxGorevi.SelectedIndex = (int)oldCoordinator.Role;
                        cmbBoxSube.Text = branchService.GetBranchNameByID(oldCoordinator.BranchID);
                        txtMailAdresi.Text = oldCoordinator.Email;
                        if (!String.IsNullOrEmpty(oldCoordinator.Photo))
                        {
                            pBoxResim.Image = Image.FromFile(oldCoordinator.Photo);
                            dosyaYolu = oldCoordinator.Photo;
                        }
                        else
                            pBoxResim.Image = null;
                        txtParola.Text = oldCoordinator.Password;
                    }
                    else
                        throw new Exception("Kullanıcı bulunamadı!");
                }
                else if (Enum.GetName(typeof(Role), 2) == cmbBoxGoreviArama.Text)
                {
                    oldEducator = educatorService.GetByEmailAddress(mailAdresi);

                    if (oldEducator != null)
                    {
                        txtAd.Text = oldEducator.Name;
                        txtSoyad.Text = oldEducator.Surname;
                        dtpDogumTarihi.Value = oldEducator.DateofBirth;
                        mTxtCepTelefonu.Text = oldEducator.Phone;
                        cmbBoxGorevi.SelectedIndex = (int)oldEducator.Role;
                        cmbBoxSube.Text = branchService.GetBranchNameByID(oldEducator.BranchID);
                        txtMailAdresi.Text = oldEducator.Email;
                        if (!String.IsNullOrEmpty(oldEducator.Photo))
                        {
                            pBoxResim.Image = Image.FromFile(oldEducator.Photo);
                            dosyaYolu = oldEducator.Photo;
                        }
                        else
                            pBoxResim.Image = null;
                        txtParola.Text = oldEducator.Password;
                    }
                    else
                        throw new Exception("Kullanıcı bulunamadı!");
                }
            }
        }

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            bool kontrolKullaniciBilgileri = ComponentControl.BlankControl(grpBoxKullaniciBilgileri);
            bool kontrolUyelikBilgileri = ComponentControl.BlankControl(grpBoxUyelikBilgileri);
            if (kontrolKullaniciBilgileri && kontrolUyelikBilgileri)
            {
                if (Enum.GetName(typeof(Role), 0) == cmbBoxGorevi.Text)
                {
                    Administrator newAdministrator = new Administrator()
                    {
                        ID = oldAdministrator.ID,
                        Name = txtAd.Text,
                        Surname = txtSoyad.Text,
                        DateofBirth = dtpDogumTarihi.Value,
                        Phone = mTxtCepTelefonu.Text,
                        Role = Role.Yonetici,
                        Photo = dosyaYolu,
                        Email = txtMailAdresi.Text,
                        Password = txtParola.Text
                    };
                    administratorService.Update(newAdministrator);
                }
                else if (Enum.GetName(typeof(Role), 1) == cmbBoxGorevi.Text)
                {
                    Coordinator newCoordinator = new Coordinator()
                    {
                        ID = oldCoordinator.ID,
                        Name = txtAd.Text,
                        Surname = txtSoyad.Text,
                        DateofBirth = dtpDogumTarihi.Value,
                        Phone = mTxtCepTelefonu.Text,
                        Role = Role.Koordinator,
                        Photo = dosyaYolu,
                        Email = txtMailAdresi.Text,
                        Password = txtParola.Text,
                        BranchID = branchService.GetBranchIDByName(cmbBoxSube.Text)
                    };
                    coordinatorService.Update(newCoordinator);
                }
                else if (Enum.GetName(typeof(Role), 2) == cmbBoxGorevi.Text)
                {
                    Educator newEducator = new Educator()
                    {
                        ID = oldEducator.ID,
                        Name = txtAd.Text,
                        Surname = txtSoyad.Text,
                        DateofBirth = dtpDogumTarihi.Value,
                        Phone = mTxtCepTelefonu.Text,
                        Role = Role.Egitmen,
                        Photo = dosyaYolu,
                        Email = txtMailAdresi.Text,
                        Password = txtParola.Text,
                        BranchID = branchService.GetBranchIDByName(cmbBoxSube.Text),
                    };
                    educatorService.Update(newEducator);
                }
                MessageBox.Show("Başarıyla güncellenmiştir..");
                listViewKullanici.Items.Clear();
                ComponentControl.ControlClean(grpBoxArama);
                ComponentControl.ControlClean(grpBoxKullaniciBilgileri);
                ComponentControl.ControlClean(grpBoxUyelikBilgileri);
                pBoxResim.Image = null;
            }
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

        private void chkBoxParolaOtomatikOlustur_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxParolaOtomatikOlustur.Checked)
            {
                txtParola.PasswordChar = '\0';
                Password passwordGenerator = new Password();
                string password = passwordGenerator.Next();
                txtParola.Text = password;
            }
            else
            {
                txtParola.Text = string.Empty;
            }
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            bool kontrolKullaniciBilgileri = ComponentControl.BlankControl(grpBoxKullaniciBilgileri);
            bool kontrolUyelikBilgileri = ComponentControl.BlankControl(grpBoxUyelikBilgileri);
            if (kontrolKullaniciBilgileri && kontrolUyelikBilgileri)
            {

                if (Enum.GetName(typeof(Role), 0) == cmbBoxGorevi.Text)
                {
                    Administrator newAdministrator = new Administrator()
                    {
                        ID = oldAdministrator.ID,
                    };
                    administratorService.Delete(newAdministrator);
                    MessageBox.Show("Başarıyla silinmiştir..");
                    ComponentControl.ControlClean(grpBoxArama);
                    ComponentControl.ControlClean(grpBoxKullaniciBilgileri);
                    ComponentControl.ControlClean(grpBoxUyelikBilgileri);
                }
                else if (Enum.GetName(typeof(Role), 1) == cmbBoxGorevi.Text)
                {
                    Coordinator newCoordinator = new Coordinator()
                    {
                        ID = oldCoordinator.ID,
                    };
                    coordinatorService.Delete(newCoordinator);
                    MessageBox.Show("Başarıyla silinmiştir..");
                    ComponentControl.ControlClean(grpBoxArama);
                    ComponentControl.ControlClean(grpBoxKullaniciBilgileri);
                    ComponentControl.ControlClean(grpBoxUyelikBilgileri);
                }
                else if (Enum.GetName(typeof(Role), 2) == cmbBoxGorevi.Text)
                {
                    Educator newEducator = new Educator()
                    {
                        ID = oldEducator.ID,
                    };
                    educatorService.Delete(newEducator);
                    MessageBox.Show("Başarıyla silinmiştir..");
                    ComponentControl.ControlClean(grpBoxArama);
                    ComponentControl.ControlClean(grpBoxKullaniciBilgileri);
                    ComponentControl.ControlClean(grpBoxUyelikBilgileri);
                }
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
    }
}