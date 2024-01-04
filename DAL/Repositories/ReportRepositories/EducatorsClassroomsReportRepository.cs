using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.ReportRepositories
{
    public class EducatorsClassroomsReportRepository
    {
        private readonly AppDbContext context;
        public EducatorsClassroomsReportRepository()
        {
            context = new AppDbContext();
        }
        public int GetEducatorCountByClassroom(string classroomID)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
            int result = context.EducatorsClassrooms.Where(x => x.ClassroomID == classroomID).Count();
            return result;
            //}
        }
    }
}
