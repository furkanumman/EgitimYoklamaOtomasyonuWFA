using BLL.Interfaces.IReportServices;
using DAL.Repositories.ReportRepositories;

namespace BLL.Services.ReportServices
{
    public class BranchReportService : IBranchReportService
    {
        private readonly BranchReportRepository _branchReportRepository;

        public BranchReportService()
        {
            _branchReportRepository = new BranchReportRepository();
        }
        public int CoordinatorCountByID(int branchID)
        {
            int result = _branchReportRepository.CoordinatorCountByID(branchID);
            return result;
        }

        public decimal EducationAmountPerEducator(int branchID)
        {
            decimal result = _branchReportRepository.EducationAmountPerEducator(branchID);
            return result;
        }

        public int EducationCountByID(int branchID)
        {
            int result = _branchReportRepository.EducationCountByID(branchID);
            return result;
        }

        public int EducatorCountByID(int branchID)
        {
            int result = _branchReportRepository.EducatorCountByID(branchID);
            return result;
        }

        public int StudentCountByID(int branchID)
        {
            int result = _branchReportRepository.StudentCountByID(branchID);
            return result;
        }

        public int TotalEducationDuration(int branchID)
        {
            int result = _branchReportRepository.TotalEducationDuration(branchID);
            return result;
        }
    }
}
