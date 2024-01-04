using BLL.Interfaces;
using BLL.Services;
using DAL;
using DATA;

namespace UI
{
    public partial class Form1 : Form
    {
        AdministratorService administratorService;
        CoordinatorService coordinatorService;
        EducatorService educatorService;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            administratorService = new AdministratorService();
            coordinatorService = new CoordinatorService();
            educatorService = new EducatorService();

            txtSifre.PasswordChar = '*';

            Administrator administrator = new Administrator()
            {
                Name = "Bilge",
                Surname = "Adam",
                Password = "1234",
                Role = DATA.Enums.Role.Yonetici,
                Phone = "5545555454",
                Email = "bilgeAdam@bilge.com",
                DateofBirth = DateTime.Now.AddYears(-25),
            };


            if (!administratorService.CheckControl(x => x.Email == administrator.Email))
                administratorService.Insert(administrator);
#if DEBUG
            txtMailAdresi.Text = administrator.Email;
            txtSifre.Text = administrator.Password;
#endif
        }

        private void chkBoxParolayiG�ster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxParolayiG�ster.Checked)
            {
                txtSifre.PasswordChar = '\0';
                chkBoxParolayiG�ster.Text = "Parolay� Gizle";
            }
            else
            {
                txtSifre.PasswordChar = '*';
                chkBoxParolayiG�ster.Text = "Parolay� G�ster";
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (administratorService.CheckControl(x => x.Email == txtMailAdresi.Text && x.Password == txtSifre.Text))
            {
                MessageBox.Show("Y�netici oturumu a��l�yor!");
                AdministratorForm yoneticiForm = new AdministratorForm();
                yoneticiForm.ShowDialog();
            }
            else if (coordinatorService.CheckControl(x => x.Email == txtMailAdresi.Text && x.Password == txtSifre.Text))
            {
                Coordinator coordinator = coordinatorService.GetByEmailAddress(txtMailAdresi.Text);
                MessageBox.Show("Koordinat�r oturumu a��l�yor!");
                CoordinatorForm coordinatorForm = new CoordinatorForm(this, coordinator);
                coordinatorForm.ShowDialog();
            }
            else if (educatorService.CheckControl(x => x.Email == txtMailAdresi.Text && x.Password == txtSifre.Text))
            {
                Educator educator = educatorService.GetByEmailAddress(txtMailAdresi.Text);
                MessageBox.Show("E�itmen oturumu a��l�yor!");
                EducatorForm educatorForm = new EducatorForm(this,educator);
                educatorForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal� !!");
            }
        }
    }
}