using DATA.Base;
using DATA.Enums;
using DATA.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Coordinator : UserEntity<int>, IPassword
    {
        public Coordinator()
        {
            Role = Role.Koordinator;
        }

        public Role Role { get; set; }
        public string Password { get; set; }

        //Navigation Prop
        public int? BranchID { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
