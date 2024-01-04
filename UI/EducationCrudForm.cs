using BLL.Services;
using DATA;

namespace UI
{
    public partial class EducationCrudForm : Form
    {
        EducationService educationService;
        int seciliEducationID;

        public EducationCrudForm()
        {
            InitializeComponent();
        }

        private void EgitimIslemForm_Load(object sender, EventArgs e)
        {
            educationService = new EducationService();
            Listele();
        }

        private void btnEgitimEkle_Click(object sender, EventArgs e)
        {
            bool kontrol = ComponentControl.BlankControl(grpBoxEgitimBilgileri);

            if (kontrol)
            {
                if (nudEgitimSuresi.Value > 0)
                {
                    Education education = new Education()
                    {
                        Name = txtEgitimAdi.Text,
                        Duration = Convert.ToInt32(nudEgitimSuresi.Value),
                        Description = txtAciklama.Text,
                        IsActive = true,
                    };

                    if (educationService.FindEducation(education) != null)
                        MessageBox.Show("Eklemeye çalıştığınız eğitim mevcuttur!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    else
                    {
                        educationService.Insert(education);
                        MessageBox.Show("Eğitim eklenmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                        ComponentControl.ControlClean(grpBoxEgitimBilgileri);
                    }
                }
                else
                    MessageBox.Show("Eğitim süresi 0'dan büyük olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEgitimGuncelle_Click(object sender, EventArgs e)
        {
            bool kontrol = ComponentControl.BlankControl(grpBoxEgitimBilgileri);

            if (kontrol)
            {
                if (nudEgitimSuresi.Value > 0)
                {
                    Education education = new Education()
                    {
                        ID = seciliEducationID,
                        Name = txtEgitimAdi.Text,
                        Duration = Convert.ToInt32(nudEgitimSuresi.Value),
                        Description = txtAciklama.Text,
                    };
                    if (seciliEducationID != -1)
                    {
                        educationService.Update(education);
                        MessageBox.Show("Eğitim güncellenmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                        ComponentControl.ControlClean(grpBoxEgitimBilgileri);
                    }
                    else
                        MessageBox.Show("Eğitim güncellenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Eğitim süresi 0'dan büyük olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnEgitimSil_Click(object sender, EventArgs e)
        {

            Education education = new Education()
            {
                Name = txtEgitimAdi.Text,
                Duration = Convert.ToInt32(nudEgitimSuresi.Value),
                Description = txtAciklama.Text,
            };

            if (educationService.FindEducation(education) != null)
            {
                educationService.Delete(education);
                Listele();
                MessageBox.Show("Eğitim silinmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEgitimAdi.Text = string.Empty;
                txtAciklama.Text = string.Empty;
                nudEgitimSuresi.Value = 0;
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz eğitim kayıtlı değildir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void Listele()
        {
            listViewEgitimBilgileri.Items.Clear();
            List<Education> educations = educationService.GetAll();
            if (educations.Count > 0)
            {
                foreach (Education e in educations)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = e.Name;
                    lvi.SubItems.Add(e.Duration.ToString());
                    lvi.SubItems.Add(e.Description);
                    listViewEgitimBilgileri.Items.Add(lvi);
                };
            }
        }

        private void listViewEgitimBilgileri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEgitimBilgileri.SelectedItems.Count > 0)
            {
                ListViewItem seciliSatir = listViewEgitimBilgileri.SelectedItems[0];

                txtEgitimAdi.Text = seciliSatir.SubItems[0].Text;
                nudEgitimSuresi.Value = Convert.ToDecimal(seciliSatir.SubItems[1].Text);
                txtAciklama.Text = seciliSatir.SubItems[2].Text;

                seciliEducationID = educationService.GetEducationID(new Education()
                {
                    Name = txtEgitimAdi.Text,
                    Duration = Convert.ToInt32(nudEgitimSuresi.Value),
                    Description = txtAciklama.Text,
                });
            }
        }
    }
}
