using DATA.Interface;

namespace DATA.Base
{
    public class UserEntity<T> : Entity<T>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateofBirth { get; set; }
        public string? Photo { get; set; }
    }
}
