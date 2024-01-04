using DATA.Base;
using DATA.Enums;
using DATA.Interface;

namespace DATA
{
    public class Administrator : UserEntity<int>, IPassword
    {
        public Administrator()
        {
            Role = Role.Yonetici;
        }
        public Role Role { get; set; }
        public string Password { get; set; }
    }
}
