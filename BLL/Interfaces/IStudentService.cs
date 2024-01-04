using BLL.Interfaces.Base;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IStudentService : IBaseService<Student, int>
    {
        public List<Student> GetStudentByClassroomID(string classroomID);
        public List<Student> GetStudentByClassroomID(Func<Student, bool> filter);

    }
}
