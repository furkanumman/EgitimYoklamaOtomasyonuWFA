using BLL.Services;
using BLL.Services.ReportServices;
using DATA;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace UI
{
    public partial class ClassroomReportForm : Form
    {
        BranchService branchService;
        ClassroomService classroomService;
        BranchReportService branchReportService;
        ClassroomReportService classroomReportService;
        EducatorsClassroomsReportService educatorsClassroomsReportService;
        StudentService studentService;


        public ClassroomReportForm()
        {
            InitializeComponent();
        }

        private void ClassroomReportForm_Load(object sender, EventArgs e)
        {
            branchService = new BranchService();
            classroomService = new ClassroomService();
            branchReportService = new BranchReportService();
            classroomReportService = new ClassroomReportService();
            educatorsClassroomsReportService = new EducatorsClassroomsReportService();
            studentService = new StudentService();

            // Şube Combobox'ı dolduruldu.
            ComponentControl.FillWithBranch(cmbSubeSec);

            // Sınıf Combobox'ı seçime kapatıldı.
            cmbSinifSec.Enabled = false;

            // deneme amaçlı
            //var result = classroomRepository.DersGunleriniGetir("Sınıf-1");
        }

        private void cmbSubeSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            int branchID = branchService.GetBranchIDByName(cmbSubeSec.Text);

            // Sınıf combobox'ı şube seçimine göre dolduruldu.
            cmbSinifSec.Items.Clear();
            var list = classroomService.Where(x => x.BranchID == branchID);
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    cmbSinifSec.Items.Add(item.ID);
                }
            }

            if (cmbSinifSec.Items.Count > 0)
                cmbSinifSec.Enabled = true;
            else
                cmbSinifSec.Enabled = false;
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            if (cmbSubeSec.SelectedIndex == -1)
            {
                MessageBox.Show("Şube seçimi yapınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbSinifSec.SelectedIndex == -1)
            {
                MessageBox.Show("Sınıf seçimi yapınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Classroom classroom = classroomService.GetClassroomByClassroomID(cmbSinifSec.Text);

            if (DateTime.Now > classroom.EducationStartDate)
            {
                if (classroom.LessonsCountUntilMoficationDate == 0)
                    lblYapilanDersSaati.Text = classroomReportService.EducationTime(cmbSinifSec.Text).ToString();
                else
                {
                    List<int> classroomLessons = classroomService.GetLessonDays(classroom.ID);
                    int modificationDateAfterLessons = classroomReportService.GetTotalLessonsCount(classroomLessons, classroom.ModificationDate, DateTime.Now);
                    lblYapilanDersSaati.Text = (classroom.LessonsCountUntilMoficationDate + modificationDateAfterLessons * classroom.DailyEducationHour).ToString();
                }
                lblKalanDersSaati.Text = classroomReportService.EducationRemainingTime(cmbSinifSec.Text).ToString();
                lblOgrenciSayisi.Text = classroomReportService.StudentCount(cmbSinifSec.Text).ToString();
                lblEgitmen.Text = educatorsClassroomsReportService.GetEducatorCountByClassroom(cmbSinifSec.Text).ToString();

                listViewSubeRaporBilgileri.Items.Clear();
                List<ListViewItem> list = new List<ListViewItem>();

                list = Listele(cmbSinifSec.Text);
                foreach (var lvi in list)
                {
                    listViewSubeRaporBilgileri.Items.Add(lvi);
                }
            }
            else
            {
                MessageBox.Show("Eğitimiz henüz başlamamıştır...");
                return;
            }
        }

        private void btnPDFKaydet_Click(object sender, EventArgs e)
        {
            PdfDocument pdf = new PdfDocument();

            PdfPage page = pdf.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont titleFont = new XFont("Arial", 20, XFontStyle.Bold);
            XFont topicFont = new XFont("Times New Roman", 12);

            gfx.DrawString($"Tarih: {DateTime.Now.ToShortDateString()}", topicFont, XBrushes.Black, new XRect(-10, 10, page.Width, page.Height), XStringFormats.TopRight);
            gfx.DrawString("SINIF RAPORU", titleFont, XBrushes.Black, new XRect(0, 20, page.Width, page.Height), XStringFormats.TopCenter);
            gfx.DrawString($"Şube Adı : {cmbSubeSec.Text}", topicFont, XBrushes.Black, new XRect(30, 60, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Sınıf Adı : {cmbSinifSec.Text}", topicFont, XBrushes.Black, new XRect(30, 90, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Yapılan Ders Saati : {lblYapilanDersSaati.Text}", topicFont, XBrushes.Black, new XRect(30, 120, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Kalan Ders Saati : {lblKalanDersSaati.Text}", topicFont, XBrushes.Black, new XRect(30, 150, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Öğrenci Sayısı : {lblOgrenciSayisi.Text}", topicFont, XBrushes.Black, new XRect(30, 180, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Eğitmen : {lblEgitmen.Text}", topicFont, XBrushes.Black, new XRect(30, 210, page.Width, page.Height), XStringFormats.TopLeft);

            int verticalPosition = 240;

            foreach (ListViewItem item in listViewSubeRaporBilgileri.Items)
            {
                // Sıra No Bilgisi
                string index = item.Text;
                // Öğrenci Adı Soyadı
                string studentNameSurname = item.SubItems[1].Text;
                // katıldığı Ders Saati
                string attendanceLessonHour = item.SubItems[2].Text;
                // Devam Oranı
                string attendanceRate = item.SubItems[3].Text;

                gfx.DrawString($"Sıra No: {index} -- Ögrenci Adı Soyadı: {studentNameSurname} -- Katıldığı Ders Saati: {attendanceLessonHour} -- Devam Oranı: {attendanceRate}", topicFont, XBrushes.Black, new XRect(30, verticalPosition, page.Width, page.Height), XStringFormats.TopLeft);
                verticalPosition += 30;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Dosyası|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pdf.Save(saveFileDialog.FileName);
                MessageBox.Show("PDF dosyası kaydedildi.");
            }
        }

        //Filtrele Butonuma tıklandığında
        private List<ListViewItem> Listele(string classroomID)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            List<Student> studentList = studentService.GetStudentByClassroomID(classroomID);

            int index = 1;

            foreach (Student student in studentList)
            {
                ListViewItem viewItem = new ListViewItem();

                viewItem.Text = index.ToString();
                viewItem.SubItems.Add($"{student.Name} {student.Surname}");

                // Katıldığı Ders Saati
                int attendanceTotalLessonHours = classroomReportService.AttendTotalLessonHour(student.ID);
                viewItem.SubItems.Add(attendanceTotalLessonHours.ToString());

                // Devam Oranı
                int totalLessonHours = classroomReportService.TotalLessonHour(student.ID);
                decimal attendanceRate = attendanceTotalLessonHours / (decimal)totalLessonHours * 100;
                viewItem.SubItems.Add(attendanceRate.ToString(".##"));

                listViewItems.Add(viewItem);
                index++;
            }
            return listViewItems;
        }
    }
}
