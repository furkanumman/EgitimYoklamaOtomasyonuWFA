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

        private void chkBoxParolayiGöster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxParolayiGöster.Checked)
            {
                txtSifre.PasswordChar = '\0';
                chkBoxParolayiGöster.Text = "Parolayý Gizle";
            }
            else
            {
                txtSifre.PasswordChar = '*';
                chkBoxParolayiGöster.Text = "Parolayý Göster";
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (administratorService.CheckControl(x => x.Email == txtMailAdresi.Text && x.Password == txtSifre.Text))
            {
                MessageBox.Show("Yönetici oturumu açýlýyor!");
                AdministratorForm yoneticiForm = new AdministratorForm();
                yoneticiForm.ShowDialog();
            }
            else if (coordinatorService.CheckControl(x => x.Email == txtMailAdresi.Text && x.Password == txtSifre.Text))
            {
                Coordinator coordinator = coordinatorService.GetByEmailAddress(txtMailAdresi.Text);
                MessageBox.Show("Koordinatör oturumu açýlýyor!");
                CoordinatorForm coordinatorForm = new CoordinatorForm(this, coordinator);
                coordinatorForm.ShowDialog();
            }
            else if (educatorService.CheckControl(x => x.Email == txtMailAdresi.Text && x.Password == txtSifre.Text))
            {
                Educator educator = educatorService.GetByEmailAddress(txtMailAdresi.Text);
                MessageBox.Show("Eðitmen oturumu açýlýyor!");
                EducatorForm educatorForm = new EducatorForm(this,educator);
                educatorForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya Þifre hatalý !!");
            }
        }
    }
}