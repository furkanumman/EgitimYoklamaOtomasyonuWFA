using DATA.Base;

namespace DATA
{
    public class Attendance : Entity<int>
    {
        public int StudentID { get; set; }
        public int LessonID { get; set; }
        public DateTime Date { get; set; }
        public bool AttendanceStatus { get; set; }

        //Navigation Property
        public virtual Student Student { get; set; }
    }
}
