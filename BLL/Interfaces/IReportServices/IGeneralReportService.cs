using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces.IReportServices
{
    public interface IGeneralReportService
    {
        public int CountAdministrator();

        public int CountBranch();

        public int CountCoordinator();

        public int CountEducator();

        public int CountStudent();

        public int CountEducation();

        public int TotalEducationDuration();
    }
}
