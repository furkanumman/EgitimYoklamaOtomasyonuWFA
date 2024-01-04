using BLL.Services;
using DATA;

namespace UI
{
    public partial class BranchCrudForm : Form
    {
        CoordinatorService coordinatorService;
        BranchService branchService;
        Branch oldBranch;

        public BranchCrudForm()
        {
            InitializeComponent();
        }

        private void SubeIslemForm_Load(object sender, EventArgs e)
        {
            coordinatorService = new CoordinatorService();
            branchService = new BranchService();
            KoordinatorListele();
            SubeListele();
            if (cmbBoxKoordinator.Items.Count == 0)
            {
                cmbBoxKoordinator.Enabled = false;
            }
        }

        void SubeListele()
        {
            listViewSubeBilgileri.Items.Clear();
            List<Branch> branches = branchService.GetAll();
            if (branches.Count > 0)
            {
                foreach (Branch b in branches)
                {
                    if (coordinatorService.Where(x => x.ID == b.ID).ToList().Count > 0)
                    {
                        foreach (Coordinator c in coordinatorService.Where(x => x.ID == b.ID).ToList())
                        {
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = b.Name;
                            //Koordinatörün ismini ve soyismini ekledik.
                            lvi.SubItems.Add($"{c.ID}-{c.Name} {c.Surname}");
                            lvi.SubItems.Add(b.Mail);
                            lvi.SubItems.Add(b.Phone);
                            listViewSubeBilgileri.Items.Add(lvi);
                        }
                    }
                    else
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = b.Name;
                        //Koordinatörün ismini ve soyismini ekledik.
                        lvi.SubItems.Add(coordinatorService.FindByBranchID(b.ID));
                        lvi.SubItems.Add(b.Mail);
                        lvi.SubItems.Add(b.Phone);
                        listViewSubeBilgileri.Items.Add(lvi);
                    }
                };
            }
        }

        private void btnSubeSil_Click(object sender, EventArgs e)
        {
            Branch branch = new Branch()
            {
                ID = oldBranch.ID,
                Name = txtSubeAdi.Text,
                Mail = txtMail.Text,
                Phone = mtbTelefon.Text,
                Adress = txtAdres.Text
            };
            if (branchService.FindBranch(branch))
            {
                branchService.Delete(branch);
                SubeListele();
                MessageBox.Show("Şube silinmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ComponentControl.ControlClean(grpBoxSubeBilgileri);
            }
        }

        private void listViewSubeBilgileri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSubeBilgileri.SelectedItems.Count > 0)
            {
                ListViewItem seciliSatir = listViewSubeBilgileri.SelectedItems[0];

                txtSubeAdi.Text = seciliSatir.SubItems[0].Text;
                if (seciliSatir.SubItems[1].Text == "-")
                    cmbBoxKoordinator.SelectedIndex = -1;
                else
                {
                    //int coordinatorID= GetCoordinatorIDfromText(seciliSatir.SubItems[1].Text);
                    cmbBoxKoordinator.SelectedItem = seciliSatir.SubItems[1].Text;
                }

                txtMail.Text = seciliSatir.SubItems[2].Text;
                mtbTelefon.Text = seciliSatir.SubItems[3].Text;
                txtAdres.Text = branchService.GetBranchAddressByName(txtSubeAdi.Text);
                oldBranch = new Branch()
                {
                    ID = branchService.GetBranchIDByName(seciliSatir.SubItems[0].Text)
                };
            }
        }

        private void btnSubeEkle_Click(object sender, EventArgs e)
        {
            Branch branch = new Branch()
            {
                Name = txtSubeAdi.Text,
                Phone = mtbTelefon.Text,
                Mail = txtMail.Text,
                Adress = txtAdres.Text,
                IsActive = true,
            };
            if (!branchService.FindBranch(branch))
            {
                branch = branchService.Insert(branch);
                MessageBox.Show("Şube eklenmiştir!",
                                "Bilgilendirme",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                // Şube eklerken koordinatör seçildiyse, koordinatör nesnesine şubeID bilgisi işlendi.
                if (cmbBoxKoordinator.SelectedIndex != -1)
                {
                    var deger = cmbBoxKoordinator.Text.Split('-');
                    int coordinatorId = Convert.ToInt32(deger[0].Trim());

                    if (!coordinatorService.HaveCoordinatoraBranch(coordinatorId))
                    {
                        coordinatorService.UpdateBranchByCoordinatorId(branch.ID, coordinatorId);
                        MessageBox.Show("Koordinatore şube bilgisi eklenmiştir..");
                        ComponentControl.ControlClean(grpBoxSubeBilgileri);
                    }
                }
            }
            else
            {
                MessageBox.Show("Şube eklenemez!",
                                "Hata",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            SubeListele();
        }

        private void btnSubeGuncelle_Click(object sender, EventArgs e)
        {
            if (oldBranch == null)
            {
                MessageBox.Show("Lütfen listeden işlem yapmak istediğiniz şubeyi seçiniz..");
                return;
            }
            Branch branch = new Branch()
            {
                Name = txtSubeAdi.Text,
                Phone = mtbTelefon.Text,
                Mail = txtMail.Text,
                Adress = txtAdres.Text,
                IsActive = true,
                ID = oldBranch.ID
            };
           
            branchService.Update(branch);
            MessageBox.Show("Şube güncellenmiştir!",
                                "Bilgilendirme",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            if (cmbBoxKoordinator.SelectedIndex != -1)
            {
                int coordinatorId = GetCoordinatorIDfromText(cmbBoxKoordinator.Text);
                coordinatorService.UpdateBranchByCoordinatorId(branch.ID, coordinatorId);
                MessageBox.Show("Koordinatore şube bilgisi eklenmiştir..");
                ComponentControl.ControlClean(grpBoxSubeBilgileri);
            }
            SubeListele();
        }

        // ComboBox Text formatı şu şekilde olmalıdır.
        // ID-Name Surname --> ID integer olacak şekilde.
        private int GetCoordinatorIDfromText(string coordinatorText)
        {
            string[] result = coordinatorText.Split('-');
            int coordinatorId = Convert.ToInt32(result[0].Trim());
            return coordinatorId;
        }

        private void KoordinatorListele()
        {
            List<Coordinator> coordinators = coordinatorService.GetAll();
            foreach (Coordinator coordinator in coordinators)
            {
                cmbBoxKoordinator.Items.Add($"{coordinator.ID}-{coordinator.Name} {coordinator.Surname}");
            }
        }
    }
}