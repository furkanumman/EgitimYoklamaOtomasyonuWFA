using BLL.Interfaces.IReportServices;
using DAL.Repositories.ReportRepositories;

namespace BLL.Services.ReportServices
{
    public class EducatorsClassroomsReportService : IEducatorsClassroomsReportService
    {

        private readonly EducatorsClassroomsReportRepository _educatorsClassroomsReportRepository;

        public EducatorsClassroomsReportService()
        {
            _educatorsClassroomsReportRepository = new EducatorsClassroomsReportRepository();
        }
        public int GetEducatorCountByClassroom(string classroomID)
        {
            int result = _educatorsClassroomsReportRepository.GetEducatorCountByClassroom(classroomID);
            return result;
        }
    }
}
