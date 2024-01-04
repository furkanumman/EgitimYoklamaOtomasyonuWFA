using DATA.Base;
using DATA.Enums;
using DATA.Interface;

namespace DATA
{
    public class Educator : UserEntity<int>, IPassword
    {
        public Educator()
        {
            Role = Role.Egitmen;
        }

        public Role Role { get; set; }
        public string Password { get; set; }

        //Navigation Prop
        public int? BranchID { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual ICollection<Classroom> Classrooms { get; set; }
       
    }
}
