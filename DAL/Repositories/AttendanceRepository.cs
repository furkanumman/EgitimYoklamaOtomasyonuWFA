using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class AttendanceRepository
    {
        private readonly AppDbContext context;

        public AttendanceRepository()
        {
            context = new AppDbContext();
        }
        public bool LessonStatus(int studentID, int lessonID, DateTime attendaceDate)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
            var result = context.Attendances.FirstOrDefault(x => x.StudentID == studentID && x.LessonID == lessonID && x.Date.Date == attendaceDate.Date);
            return result.AttendanceStatus;
            //}
        }

        public bool AnyAttendanceByAttendanceDate(DateTime date)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
            var result = context.Attendances.FirstOrDefault(x => x.Date.Date == date.Date);
            if (result == null)
                return false;

            return true;
            //}
        }
    }
}
