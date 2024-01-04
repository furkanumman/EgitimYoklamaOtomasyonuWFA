using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces.IReportServices
{
    public interface IBranchReportService
    {
        public int CoordinatorCountByID(int branchID);
        public int EducatorCountByID(int branchID);

        public int StudentCountByID(int branchID);


        // bir şubede verilen eğitim sayısı, eğitimler tekrar edebilir.
        public int EducationCountByID(int branchID);

        public int TotalEducationDuration(int branchID);

        public decimal EducationAmountPerEducator(int branchID);
    }
}
