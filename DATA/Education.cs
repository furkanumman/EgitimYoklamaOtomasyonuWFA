using DATA.Base;
using DATA.Interface;

namespace DATA
{
    public class Education : Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

        //Navigation Prop
        public ICollection<Classroom> Classrooms { get; set; }
    }
}
