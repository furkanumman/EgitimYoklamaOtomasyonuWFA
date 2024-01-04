using DATA.Base;
using DATA.Interface;

namespace DATA
{
    public class Classroom : Entity<string>
    {
        public int BranchID { get; set; }
        public int EducationID { get; set; }
        public bool IsActive { get; set; }
        public DateTime EducationStartDate { get; set; }
        public DateTime EducationFinishDate { get; set; }
        public string EducationStartTime { get; set; }
        public string EducationFinishTime { get; set; }
        public int DailyEducationHour { get; set; }
        public bool IsLessonsOnMonday { get; set; }
        public bool IsLessonsOnTuesday { get; set; }
        public bool IsLessonsOnWednesday { get; set; }
        public bool IsLessonsOnThursday { get; set; }
        public bool IsLessonsOnFriday { get; set; }
        public bool IsLessonsOnSaturday { get; set; }
        public bool IsLessonsOnSunday { get; set; }
        public DateTime ModificationDate { get; set; }
        public int LessonsCountUntilMoficationDate { get; set; } = 0;

        //Navigation Prop
        public virtual ICollection<Educator> Educators { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Education Education { get; set; }

        // NOTTTT ::  LİSTELERİ TANITMADIK CONSTRUCTOR DA SORUN ÇIKARSA TANITMAYI UNUTMA !!!!! 
    }
}
