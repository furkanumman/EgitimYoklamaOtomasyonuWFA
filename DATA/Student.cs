using DATA.Base;

namespace DATA
{
    public class Student : UserEntity<int>
    {
        // Navigation Properties
        public string ClassroomID { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
