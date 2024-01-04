using BLL.Services;
using BLL.Services.ReportServices;
using DATA;

namespace UI
{
    public partial class ClassroomCrudForm : Form
    {
        EducatorService educatorService;
        EducationService educationService;
        ClassroomService classroomService;
        ClassroomReportService classroomReportService;
        BranchService branchRepository;
        EducatorClassroomService educatorsClassroomsService;
        Classroom oldClassroom;
        Coordinator arrivalCoordinator;
        public ClassroomCrudForm()
        {
            InitializeComponent();
        }
        public ClassroomCrudForm(Coordinator coordinator)
        {
            arrivalCoordinator = coordinator;
            InitializeComponent();
        }

        private void ClassroomCrudForm_Load(object sender, EventArgs e)
        {
            educatorService = new EducatorService();
            educationService = new EducationService();
            classroomService = new ClassroomService();
            classroomReportService = new ClassroomReportService();
            branchRepository = new BranchService();
            educatorsClassroomsService = new EducatorClassroomService();

            // Liste yapılarının (ComboBox + ListView) doldurulması. 
            EducationList();
            EducatorList();
            if (arrivalCoordinator != null)
            {
                ClassroomList(arrivalCoordinator);
            }
            else
            {
                ClassroomList();
            }

        }

        /// <summary>
        /// Sınıf Ekleme İşlemi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSinifEkle_Click(object sender, EventArgs e)
        {
            if (SelectedControl(cmbEgitim) && SelectedControl(cmbEgitmen))
            {
                if (EducationDurationControl() && DateControl())
                {
                    if (ComponentControl.BlankControl(grpSınıfBilgileri) && ComponentControl.BlankControl(grpEgitimBilgileri))
                    {
                        if (!classroomService.CheckControl(x => x.ID == txtSinifKodu.Text))
                        {
                            try
                            {
                                Classroom classroom = GetDataOnForm();
                                classroom.ModificationDate = DateTime.Now;
                                classroomService.Insert(classroom);
                                MessageBox.Show("Sınıf oluşturulmuştur.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                string[] egitmenBilgisi = cmbEgitmen.Text.Split('-');
                                int egitmenID = Convert.ToInt32(egitmenBilgisi[0].Trim());

                                EducatorClassroom educatorsClassrooms = new EducatorClassroom()
                                {
                                    ClassroomID = classroom.ID,
                                    EducatorID = egitmenID,
                                    IsActive = true
                                };
                                educatorsClassroomsService.Insert(educatorsClassrooms);
                                ClassroomList();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Sınıf oluşturulamamıştır!\nLütfen sınıf kodunuzu kontrol ediniz!",
                                                "Hata",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sınıf oluşturulamamıştır!",
                                            "Hata",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void cmbEgitmen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEgitmen.SelectedIndex == -1)
                return;

            string[] egitmenAdi = cmbEgitmen.Text.Split('-');
            int egitmenID = Convert.ToInt32(egitmenAdi[0]);
            Educator educator = new Educator() { ID = egitmenID };
            educator = educatorService.GetByID(educator);
            lblSubeAdi.Text = branchRepository.GetBranchNameByID(educator.BranchID);
        }

        /// <summary>
        /// Sınıf Güncelleme İşlemi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSinifGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sınıfa ait eğitim bilgileri güncellenecektir.\nGüncelleme yapmak istediğinizden emin misiniz?"
                            , "Bilgilendirme"
                            , MessageBoxButtons.YesNo
                            , MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Classroom newClassroom = new Classroom()
                {
                    ID = oldClassroom.ID,
                    IsLessonsOnMonday = chklistegitimGunleri.GetItemChecked(0),
                    IsLessonsOnTuesday = chklistegitimGunleri.GetItemChecked(1),
                    IsLessonsOnWednesday = chklistegitimGunleri.GetItemChecked(2),
                    IsLessonsOnThursday = chklistegitimGunleri.GetItemChecked(3),
                    IsLessonsOnFriday = chklistegitimGunleri.GetItemChecked(4),
                    IsLessonsOnSaturday = chklistegitimGunleri.GetItemChecked(5),
                    IsLessonsOnSunday = chklistegitimGunleri.GetItemChecked(6),
                    DailyEducationHour = (int)numericEgitimSuresi.Value,
                    EducationStartTime = mtxtBaslangicsaati.Text,
                    EducationFinishTime = mtxtBitisSaati.Text
                };

                // CheckListBox'taki seçili olan günleri listeye aldık.
                var selectedItemsIndex = new List<int>();
                for (int i = 0; i <= (chklistegitimGunleri.Items.Count - 1); i++)
                {
                    if (chklistegitimGunleri.GetItemChecked(i))
                        selectedItemsIndex.Add(i + 1);
                }

                // kalan eğitim süresi
                int remainingLessonHour = classroomReportService.EducationRemainingTime(oldClassroom.ID);

                // Bugün ile Eğitim bitiş tarihi arasında toplam kaç ders yapılacağı hesaplandı!
                int selectedDaysOfWeek = classroomReportService.GetTotalLessonsCount(selectedItemsIndex, DateTime.Now, oldClassroom.EducationFinishDate);

                if (remainingLessonHour == newClassroom.DailyEducationHour * selectedDaysOfWeek)
                {
                    newClassroom.LessonsCountUntilMoficationDate = classroomReportService.EducationTime((oldClassroom.ID));
                    newClassroom.ModificationDate = DateTime.Now;
                    classroomService.Update(newClassroom);

                    ClassroomList();
                    MessageBox.Show("Güncelleme işlemi gerçekleştirilmiştir!"
                                    , "Bilgilendirme"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);
                    ComponentControl.ControlClean(grpEgitimBilgileri);
                    ComponentControl.ControlClean(grpSınıfBilgileri);
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi gerçekleştirilmemiştir!\n" +
                                    "Eğitim günlerini ve günlük ders süresini kontrol ediniz!"
                                    , "Uyarı"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi iptal edilmiştir!"
                                , "Bilgilendirme"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                ComponentControl.ControlClean(grpSınıfBilgileri);
                ComponentControl.ControlClean(grpEgitimBilgileri);
            }
        }

        /// <summary>
        /// Sınıf Silme İşlemi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSinifSil_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtSinifKodu.Text))
            {
                MessageBox.Show("Sınıf kodu boş bırakılamaz!",
                                "Hata",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            Classroom classroom = new Classroom() { ID = txtSinifKodu.Text };
            try
            {
                classroomService.Delete(classroom);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                    , "Hata"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Sınıf silinmiştir!",
                                "Bilgilendirme",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            return;

        }

        // Ekrandaki değerleri alma
        private Classroom GetDataOnForm()
        {
            string[] egitimKelimeleri = cmbEgitim.Text.Split('-');
            int egitimSure = Convert.ToInt32(egitimKelimeleri[1].Replace("Saat", "").Trim());
            Education education = educationService.FindIDByNameDuration(egitimKelimeleri[0].Trim(), egitimSure);
            Classroom classroom = new Classroom()
            {
                ID = txtSinifKodu.Text,
                EducationStartDate = dtpBaslangicTarihi.Value,
                EducationFinishDate = dtpBitisTarihi.Value,
                EducationStartTime = mtxtBaslangicsaati.Text,
                EducationFinishTime = mtxtBitisSaati.Text,
                DailyEducationHour = (int)numericEgitimSuresi.Value,
                EducationID = education.ID,
                BranchID = branchRepository.GetBranchIDByName(lblSubeAdi.Text),
                IsActive = true,
                IsLessonsOnMonday = chklistegitimGunleri.GetItemChecked(0),
                IsLessonsOnTuesday = chklistegitimGunleri.GetItemChecked(1),
                IsLessonsOnWednesday = chklistegitimGunleri.GetItemChecked(2),
                IsLessonsOnThursday = chklistegitimGunleri.GetItemChecked(3),
                IsLessonsOnFriday = chklistegitimGunleri.GetItemChecked(4),
                IsLessonsOnSaturday = chklistegitimGunleri.GetItemChecked(5),
                IsLessonsOnSunday = chklistegitimGunleri.GetItemChecked(6)
            };
            return classroom;
        }

        private void listViewsinifListele_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewsinifListele.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = listViewsinifListele.SelectedItems[0];
                string classroomID = selectedRow.SubItems[0].Text;
                WriteDataOnFormControls(classroomID);
                oldClassroom = new Classroom()
                {
                    ID = selectedRow.SubItems[0].Text,
                    EducationStartDate = Convert.ToDateTime(selectedRow.SubItems[2].Text),
                    EducationFinishDate = Convert.ToDateTime(selectedRow.SubItems[3].Text),
                };
            }
        }


        // Listview'de seçim yaptıktan sonra Ekranı dolduran method
        private void WriteDataOnFormControls(string classroomID)
        {
            Classroom classroom = classroomService.GetClassroomByClassroomID(classroomID);

            txtSinifKodu.Text = classroom.ID;
            dtpBaslangicTarihi.Value = classroom.EducationStartDate;
            dtpBitisTarihi.Value = classroom.EducationFinishDate;

            Education education = new Education() { ID = classroom.EducationID };
            education = educationService.FindEducation(education);
            cmbEgitim.SelectedItem = $"{education.Name} - {education.Duration} Saat";

            Educator educator = EducatorInformation(classroom.ID);
            cmbEgitmen.SelectedItem = $"{educator.ID}-{educator.Name} {educator.Surname}";

            // Eğitim Bilgileri GroupBox içindeki controlleri doldurduk.
            chklistegitimGunleri.SetItemChecked(0, classroom.IsLessonsOnMonday);
            chklistegitimGunleri.SetItemChecked(1, classroom.IsLessonsOnTuesday);
            chklistegitimGunleri.SetItemChecked(2, classroom.IsLessonsOnWednesday);
            chklistegitimGunleri.SetItemChecked(3, classroom.IsLessonsOnThursday);
            chklistegitimGunleri.SetItemChecked(4, classroom.IsLessonsOnFriday);
            chklistegitimGunleri.SetItemChecked(5, classroom.IsLessonsOnSaturday);
            chklistegitimGunleri.SetItemChecked(6, classroom.IsLessonsOnSunday);
            numericEgitimSuresi.Value = classroom.DailyEducationHour;
            mtxtBaslangicsaati.Text = classroom.EducationStartTime;
            mtxtBitisSaati.Text = classroom.EducationFinishTime;
        }

        // Listeleme Metodları
        public void EducatorList()
        {
            List<Educator> educators = educatorService.GetAll();
            foreach (Educator educator in educators)
            {
                cmbEgitmen.Items.Add($"{educator.ID}-{educator.Name} {educator.Surname}");
            }
        }
        public void EducationList()
        {
            List<Education> educations = educationService.GetAll();
            foreach (Education education in educations)
            {
                cmbEgitim.Items.Add($"{education.Name} - {education.Duration} Saat");
            }
        }
        public void ClassroomList()
        {
            // Form'daki ListView kontrolünü dolduran method.

            listViewsinifListele.Items.Clear();

            List<Classroom> allClassroomList = classroomService.GetAll();

            foreach (Classroom item in allClassroomList)
            {
                Education education = new Education() { ID = item.EducationID };
                education = educationService.FindEducation(education);

                // Eğitmenin adı bulunur.
                Educator educator = EducatorInformation(item.ID);

                // ListViewItem oluşturulur.
                ListViewItem listItem = new ListViewItem();

                listItem.Text = item.ID;
                listItem.SubItems.Add(education.Name);
                listItem.SubItems.Add(item.EducationStartDate.ToShortDateString());
                listItem.SubItems.Add(item.EducationFinishDate.ToShortDateString());
                listItem.SubItems.Add($"{educator.Name} {educator.Surname}");
                listViewsinifListele.Items.Add(listItem);
            }
        }
        public void ClassroomList(Coordinator coordinator)
        {
            // Form'daki ListView kontrolünü dolduran method.

            listViewsinifListele.Items.Clear();

            List<Classroom> allClassroomListByCoordinator = classroomService.Where(x => x.BranchID == coordinator.BranchID);

            foreach (Classroom item in allClassroomListByCoordinator)
            {
                Education education = new Education() { ID = item.EducationID };
                education = educationService.FindEducation(education);

                // Eğitmenin adı bulunur.
                Educator educator = EducatorInformation(item.ID);

                // ListViewItem oluşturulur.
                ListViewItem listItem = new ListViewItem();

                listItem.Text = item.ID;
                listItem.SubItems.Add(education.Name);
                listItem.SubItems.Add(item.EducationStartDate.ToShortDateString());
                listItem.SubItems.Add(item.EducationFinishDate.ToShortDateString());
                listItem.SubItems.Add($"{educator.Name} {educator.Surname}");
                listViewsinifListele.Items.Add(listItem);
            }
        }
        // Kademeli sorgular ile eğitmeni bulan method.
        private Educator EducatorInformation(string classroomID)
        {
            EducatorClassroom classroomEducator = new EducatorClassroom() { ClassroomID = classroomID };
            classroomEducator = educatorsClassroomsService.GetEducatorClassroom(classroomEducator);
            Educator educator = new Educator() { ID = classroomEducator.EducatorID };
            educator = educatorService.GetByID(educator);
            return educator;
        }

        public bool EducationDurationControl()
        {
            //   eğitim saati / (bitiş tarihi- başlangıç tarihi hafta bazında) = kaç gün * günlük saat
            #region Egitim Saati
            string[] egitimKelimeleri = cmbEgitim.Text.Split('-');
            int egitimSure = Convert.ToInt32(egitimKelimeleri[1].Replace("Saat", "").Trim());
            Education education = educationService.FindIDByNameDuration(egitimKelimeleri[0].Trim(), egitimSure);
            #endregion

            #region Hafta Bazında
            DateTime baslangicTarihi = dtpBaslangicTarihi.Value;
            DateTime bitisTarihi = dtpBitisTarihi.Value;
            TimeSpan günSayisi = (bitisTarihi - baslangicTarihi);
            int haftaSayisi = (int)(günSayisi.TotalDays / 7);
            #endregion

            int haftalikDersGunuSayisi = chklistegitimGunleri.CheckedItems.Count;
            double saatGun = (double)numericEgitimSuresi.Value;

            if ((egitimSure / haftaSayisi) != haftalikDersGunuSayisi * saatGun)
            {
                MessageBox.Show("Seçtiğiniz günler, eğitim süresini karşılamamaktadır. Lütfen kontrol ediniz.");
                return false;
            }
            return true;
        }

        public bool SelectedControl(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show($"{comboBox.Tag} boş bırakılamaz !!");
                return false;
            }
            return true;
        }
        private bool DateControl()
        {
            if (dtpBaslangicTarihi.Value > dtpBitisTarihi.Value)
            {
                MessageBox.Show("Eğitimin başlangıç tarihi, bitiş tarihinden büyük olamaz !! ");
                return false;
            }
            return true;
        }
    }
}
