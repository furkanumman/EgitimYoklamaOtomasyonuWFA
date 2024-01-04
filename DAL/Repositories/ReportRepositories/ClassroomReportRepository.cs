using DATA;
using System.Globalization;

namespace DAL.Repositories.ReportRepositories
{
    public class ClassroomReportRepository 
    {

        private readonly AppDbContext context;

        EducationRepository educationRepository = new EducationRepository();
        ClassroomRepository classroomRepository = new ClassroomRepository();
        StudentRepository studentRepository = new StudentRepository();


        public ClassroomReportRepository()
        {
            context = new AppDbContext();
        }

        // Başlangıç ile Bugün arasında yapılan eğitim saati
        public int EducationTime(string classroomID)
        {
            List<int> lessonDays = classroomRepository.GetLessonDays(classroomID);
            Classroom classroom = classroomRepository.GetClassroomByClassroomID(classroomID);
            int educationTime = 0;
            if (classroom.LessonsCountUntilMoficationDate == 0)
            {
                int totalLessonsDays = GetTotalLessonsCount(lessonDays, classroom.EducationStartDate);
                educationTime = totalLessonsDays * classroom.DailyEducationHour;
            }
            else
            {
                List<int> classroomLessons = classroomRepository.GetLessonDays(classroom.ID);
                int lessonCountAfterModification = GetTotalLessonsCount(classroomLessons, classroom.ModificationDate, DateTime.Now);
                educationTime = classroom.LessonsCountUntilMoficationDate + (lessonCountAfterModification * classroom.DailyEducationHour);
            }
            return educationTime;
        }

        // Eğitimin Kalan Ders Saati
        public int EducationRemainingTime(string classroomID)
        {
            Classroom classroom = classroomRepository.GetClassroomByClassroomID(classroomID);
            Education education = new Education() { ID = classroom.EducationID };
            education = educationRepository.FindEducation(education);
            int totalEducationDuration = education.Duration;
            int educationTime = EducationTime(classroomID);

            return totalEducationDuration - educationTime;
        }

        public int StudentCount(string classroomID)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                int result = context.Students.Where(x => x.ClassroomID == classroomID).Count();
                return result;
            //}
        }


        public int EducatorCount(string classroomID)
        {
            using (AppDbContext context = new AppDbContext())
            {
                // Many-to-Many tablodan sorgu ile çekilecek!
                return -1;
                // 
                //int result = context.Students.Where(x => x.ClassroomID == classroomID).Count();
                //return result;
            }
        }

        #region kaldır

        // Filtrele Butonuma tıklandığında
        //public List<ListViewItem> Listele(string classroomID)
        //{
        //    List<ListViewItem> listViewItems = new List<ListViewItem>();
        //    List<Student> studentList = studentRepository.GetStudentByClassroomID(classroomID);

        //    int index = 1;

        //    foreach (Student student in studentList)
        //    {
        //        ListViewItem viewItem = new ListViewItem();

        //        viewItem.Text = index.ToString();
        //        viewItem.SubItems.Add($"{student.Name} {student.Surname}");

        //        // Katıldığı Ders Saati
        //        int attendanceTotalLessonHours = AttendTotalLessonHour(student.ID);
        //        viewItem.SubItems.Add(attendanceTotalLessonHours.ToString());

        //        // Devam Oranı
        //        int totalLessonHours = TotalLessonHour(student.ID);
        //        decimal attendanceRate = attendanceTotalLessonHours / (decimal)totalLessonHours * 100;
        //        viewItem.SubItems.Add(attendanceRate.ToString(".##"));

        //        listViewItems.Add(viewItem);
        //        index++;
        //    }
        //    return listViewItems;
        //} 
        #endregion

        // ÖğrenciID ve yoklama durumuna göre sorgu
        // Öğrencinin katıldığı derslerin toplam saati
        public int AttendTotalLessonHour(int studentID)
        {
            using (AppDbContext context = new AppDbContext())
            {
                int result = context.Attendances.Where(x => x.StudentID == studentID && x.AttendanceStatus == true).Count();
                return result;
            }
        }

        // ÖğrenciID ve yoklama durumuna göre sorgu
        // Öğrencinin toplam ders saati
        public int TotalLessonHour(int studentID)
        {
            using (AppDbContext context = new AppDbContext())
            {
                int result = context.Attendances.Where(x => x.StudentID == studentID).Count();
                return result;
            }
        }

        // Başlangıç tarihi ile bugün arasında haftanın seçilen günlerine göre toplam ders gün sayısını vermektedir.
        public int GetTotalLessonsCount(List<int> indexList, DateTime startDate, DateTime finishDate)
        {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture; // Geçerli kültürü al
            Calendar calendar = cultureInfo.Calendar;
            CalendarWeekRule weekRule = cultureInfo.DateTimeFormat.CalendarWeekRule;
            DayOfWeek firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;

            // Tarihlerin Hafta Numaraları alındı.
            int startDateWeekNumber = calendar.GetWeekOfYear(startDate, weekRule, firstDayOfWeek);
            int finishDateWeekNumber = calendar.GetWeekOfYear(finishDate, weekRule, firstDayOfWeek);

            int startDateIndex = ((int)startDate.DayOfWeek + 6) % 7 + 1;
            int finishDateIndex = ((int)finishDate.DayOfWeek + 6) % 7 + 1;

            int countStartDateLessons = indexList.Count(c => c >= startDateIndex);
            int countFinishDateLessons = indexList.Count(c => c <= finishDateIndex);

            int totalLessonsCount = 0;

            if (startDate.Year == finishDate.Year)
                totalLessonsCount = countStartDateLessons + countFinishDateLessons + (finishDateWeekNumber - startDateWeekNumber - 1) * indexList.Count;
            else
                totalLessonsCount = countStartDateLessons + countFinishDateLessons + (finishDateWeekNumber - startDateWeekNumber - 1 + 53) * indexList.Count;

            return totalLessonsCount;
        }
        private int GetTotalLessonsCount(List<int> indexList, DateTime startDate)
        {
            return GetTotalLessonsCount(indexList, startDate, DateTime.Now);
        }
    }

}
