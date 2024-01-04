using BLL.Interfaces.Base;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IEducatorClassroomService : IBaseService<EducatorClassroom, int>
    {
        public EducatorClassroom GetEducatorClassroom(EducatorClassroom educatorsClassrooms);
    }
}
