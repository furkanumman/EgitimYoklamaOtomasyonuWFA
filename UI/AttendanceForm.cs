using BLL.Interfaces;
using BLL.Services;
using DATA;

namespace UI
{
    public partial class AttendanceForm : Form
    {

        ClassroomService classroomService;
        StudentService studentService;
        AttendanceService attendanceService;
        Educator arrivalEducator;
        BranchService branchService;
        EducatorClassroomService educatorClassroomService;

        TableLayoutPanel tlpStudent = new TableLayoutPanel();

        public AttendanceForm()
        {
            InitializeComponent();
        }
        public AttendanceForm(Educator educator)
        {
            arrivalEducator = educator;
            InitializeComponent();
        }
        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            classroomService = new ClassroomService();
            studentService = new StudentService();
            attendanceService = new AttendanceService();
            branchService= new BranchService();
            educatorClassroomService = new EducatorClassroomService();

            if (arrivalEducator != null)
            {
                string branchName = branchService.GetBranchNameByID(arrivalEducator.BranchID);
                lblSube.Text = branchName;
                var list = educatorClassroomService.Where(x => x.EducatorID == arrivalEducator.ID).ToList();
                foreach ( var item in list )
                {
                    cmbSinif.Items.Add( item.ClassroomID );
                }
            }
            else
            {
                ListClassroom();
            }
        }

        private void btnYoklamaBul_Click(object sender, EventArgs e)
        {

            // seçtiğim tarihte sınıfın dersi yoksa --> "Sınıfın seçilen gün için dersi bulunmamaktadır." uyarısı ver.
            // dersi varsa ve yoklama tablosunda veri yoksa checkbox'ları checked özelliği false getir
            // dersi var ve yoklama talebinde veri varsa tableLayoutPaneli doldur getir.

            if (cmbSinif.SelectedIndex == -1)
            {
                MessageBox.Show("Sınıf seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Classroom classroom = classroomService.GetClassroomByClassroomID(cmbSinif.Text);
            int lessonCount = classroom.DailyEducationHour;

            DateTime attendanceDate = dtpYoklamaTarihi.Value;
            bool anyAttendanceDate = attendanceService.AnyAttendanceByAttendanceDate(attendanceDate);

            if (classroom.EducationStartDate.Date > attendanceDate.Date)
            {
                MessageBox.Show("Eğitim başlangıç tarihinden önce tarih girdiniz!");
                return;
            }

            if (classroom.EducationFinishDate.Date < attendanceDate.Date)
            {
                MessageBox.Show("Eğitim bitiş tarihinden sonra tarih girdiniz!");
                return;
            }

            // Pazartesi(1) - Pazar(7)
            int dateIndex = ((int)attendanceDate.DayOfWeek + 6) % 7 + 1;
            List<int> lessonDays = classroomService.GetLessonDays(cmbSinif.Text);
            var result = lessonDays.Contains(dateIndex);

            if (!result)
            {
                MessageBox.Show("Sınıfın seçilen gün için dersi bulunmamaktadır.");
                tlpStudent.Controls.Clear();
                return;
            }

            List<Student> studentList = studentService.GetStudentByClassroomID(x => x.ClassroomID == cmbSinif.Text);

            if (studentList.Count == 0)
            {
                MessageBox.Show("Sınıfta öğrenci kaydı bulunmamaktadır.");
                tlpStudent.Controls.Clear();
                return;
            }


            tlpStudent.Location = new System.Drawing.Point(12, 139);//new Point(12, 139);
            tlpStudent.Size = new System.Drawing.Size(809, 450);
            tlpStudent.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpStudent.AutoScroll = true;

            for (int i = 0; i < studentList.Count + 1; i++)
            {
                tlpStudent.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                if (i == 0)
                {
                    Label columnConstantStudentName = new Label();
                    columnConstantStudentName.Text = $"ÖĞRENCİ ADI";
                    tlpStudent.Controls.Add(columnConstantStudentName, 0, i);
                }

                if (i > 0)
                {
                    Label columnStudentName = new Label();
                    columnStudentName.Text = $"{studentList[i - 1].Name} {studentList[i - 1].Surname}";
                    tlpStudent.Controls.Add(columnStudentName, 0, i);
                }

                for (int j = 0; j < lessonCount + 1; j++)
                {
                    tlpStudent.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    tlpStudent.PerformLayout();
                    if (i == 0 && j < lessonCount)
                    {
                        Label columnName = new Label();
                        columnName.Text = $"Ders {j + 1}";
                        tlpStudent.Controls.Add(columnName, j + 1, i);
                    }
                    else if (j > 0 && i > 0)
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Text = ""; //$"CheckBox";
                        if (anyAttendanceDate)
                            checkBox.Checked = attendanceService.LessonStatus(studentList[i - 1].ID, j, attendanceDate);

                        tlpStudent.Controls.Add(checkBox, j, i);

                    }
                }
            }
            this.Controls.Add(tlpStudent);
        }

        void ListClassroom()
        {
            List<Classroom> listClassroom = classroomService.GetAll();
            foreach (Classroom classroom in listClassroom)
            {
                cmbSinif.Items.Add(classroom.ID);
            }
        }

        private void cmbSinif_SelectedIndexChanged(object sender, EventArgs e)
        {
            tlpStudent.Controls.Clear();
        }

        private void dtpYoklamaTarihi_ValueChanged(object sender, EventArgs e)
        {
            tlpStudent.Controls.Clear();
        }

        private void btnTumOgrencileriSec_Click(object sender, EventArgs e)
        {
            foreach (Control item in tlpStudent.Controls)
            {
                if (item is CheckBox)
                    ((CheckBox)item).Checked = true;
            }
        }

        private void btnHicSecme_Click(object sender, EventArgs e)
        {
            foreach (Control item in tlpStudent.Controls)
            {
                if (item is CheckBox)
                    ((CheckBox)item).Checked = false;
            }
        }

        private void btnYoklamaGir_Click(object sender, EventArgs e)
        {

        }
    }
}
