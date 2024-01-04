using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces.IReportServices
{
    public interface IEducatorsClassroomsReportService
    {
        public int GetEducatorCountByClassroom(string classroomID);
    }
}
