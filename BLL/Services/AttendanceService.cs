using BLL.Interfaces;
using DAL.Repositories;

namespace BLL.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly AttendanceRepository _attendanceRepository;

        public AttendanceService()
        {
            _attendanceRepository = new AttendanceRepository();
        }
        public bool AnyAttendanceByAttendanceDate(DateTime date)
        {
            bool result = _attendanceRepository.AnyAttendanceByAttendanceDate(date);
            return result;
        }

        public bool LessonStatus(int studentID, int lessonID, DateTime attendaceDate)
        {
            bool result = _attendanceRepository.LessonStatus(studentID, lessonID, attendaceDate);
            return result;
        }
    }
}
