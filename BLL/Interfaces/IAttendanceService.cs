using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAttendanceService
    {
        public bool LessonStatus(int studentID, int lessonID, DateTime attendaceDate);
        public bool AnyAttendanceByAttendanceDate(DateTime date);
    }
}
