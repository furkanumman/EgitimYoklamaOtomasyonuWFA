using DATA.Base;
using DATA.Interface;

namespace DATA
{
    public class Branch : Entity<int>
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public bool IsActive { get; set; }


        //Navigation Propety 
        public virtual ICollection<Classroom> Classrooms { get; set; }
        public virtual ICollection<Coordinator> Coordinators { get; set; }
        public virtual ICollection<Educator> Educators { get; set; }

    }
}