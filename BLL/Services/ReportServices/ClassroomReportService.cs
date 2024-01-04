using BLL.Interfaces.IReportServices;
using DAL.Repositories.ReportRepositories;

namespace BLL.Services.ReportServices
{
    public class ClassroomReportService : IClassroomReportService
    {
        private readonly ClassroomReportRepository _classroomReportRepository;
        public ClassroomReportService()
        {
            _classroomReportRepository = new ClassroomReportRepository();
        }

        public int AttendTotalLessonHour(int studentID)
        {
            int result = _classroomReportRepository.AttendTotalLessonHour(studentID);
            return result;
        }

        public int EducationRemainingTime(string classroomID)
        {
            int result = _classroomReportRepository.EducationRemainingTime(classroomID);
            return result;
        }

        public int EducationTime(string classroomID)
        {
            int result = _classroomReportRepository.EducationTime(classroomID);
            return result;
        }

        public int EducatorCount(string classroomID)
        {
            throw new NotImplementedException();
        }

        public int GetTotalLessonsCount(List<int> indexList, DateTime startDate, DateTime finishDate)
        {
            int result = _classroomReportRepository.GetTotalLessonsCount(indexList, startDate, finishDate);
            return result;
        }

        public int StudentCount(string classroomID)
        {
            int result = _classroomReportRepository.StudentCount(classroomID);
            return result;
        }

        public int TotalLessonHour(int studentID)
        {
            int result = _classroomReportRepository.TotalLessonHour(studentID);
            return result;
        }
    }
}
