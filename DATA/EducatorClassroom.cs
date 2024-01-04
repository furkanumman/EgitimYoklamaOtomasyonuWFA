using DATA.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA
{
    public class EducatorClassroom : Entity<int>
    {
        [ForeignKey("Educator")]
        public int EducatorID { get; set; }

        [ForeignKey("Classroom")]
        [MaxLength(15)]
        public string ClassroomID { get; set; }

        // Navigation Properties
        public virtual Educator Educator { get; set; }

        public virtual Classroom Classroom { get; set; }

    }
}
