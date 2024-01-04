namespace BLL.Interfaces.IReportServices
{
    public interface IClassroomReportService
    {
        public int EducationTime(string classroomID);

        public int EducationRemainingTime(string classroomID);

        public int StudentCount(string classroomID);

        public int GetTotalLessonsCount(List<int> indexList, DateTime startDate, DateTime finishDate);

        public int EducatorCount(string classroomID);

        public int AttendTotalLessonHour(int studentID);

        public int TotalLessonHour(int studentID);
    }
}
