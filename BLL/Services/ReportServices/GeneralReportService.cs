using BLL.Interfaces.IReportServices;
using DAL.Repositories.ReportRepositories;

namespace BLL.Services.ReportServices
{
    public class GeneralReportService : IGeneralReportService
    {
        private readonly GeneralReportRepository _generalReportRepository;

        public GeneralReportService()
        {
            _generalReportRepository = new GeneralReportRepository();   
        }

        public int CountAdministrator()
        {
            int result = _generalReportRepository.CountAdministrator();
            return result;
        }

        public int CountBranch()
        {
            int result = _generalReportRepository.CountBranch();
            return result;
        }

        public int CountCoordinator()
        {
            int result = _generalReportRepository.CountCoordinator();
            return result;
        }

        public int CountEducation()
        {
            int result = _generalReportRepository.CountEducation();
            return result;
        }

        public int CountEducator()
        {
            int result = _generalReportRepository.CountEducator();
            return result;
        }

        public int CountStudent()
        {
            int result = _generalReportRepository.CountStudent();
            return result;
        }

        public int TotalEducationDuration()
        {
            int result = _generalReportRepository.TotalEducationDuration();
            return result;
        }
    }
}
