using DAL.Repositories.Base;
using DATA;

namespace DAL.Repositories
{
    public class StudentRepository : BaseRepository<Student, int>
    {
        public List<Student> GetStudentByClassroomID(string classroomID)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
            var result = _context.Students.Where(x => x.ClassroomID == classroomID).ToList();
            return result;
            //}
        }

        public List<Student> GetStudentByClassroomID(Func<Student, bool> filter)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
            var list = _context.Students.Where(filter).ToList();
            return list;
            //}
        }

    }
}
