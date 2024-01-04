using BLL.Interfaces;
using DAL.Repositories;
using DATA;

namespace BLL.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentRepository _studentRepository;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        public bool CheckControl(Func<Student, bool> filter)
        {
            bool result = _studentRepository.CheckControl(filter);
            return result;
        }

        public Student Delete(Student entity)
        {
            var student = _studentRepository.Delete(entity);
            return student;
        }

        public List<Student> GetAll()
        {
            var list = _studentRepository.GetAll();
            return list;
        }

        public Student GetByID(Student entity)
        {
            var result = _studentRepository.GetByID(entity);
            return result;
        }

        public List<Student> GetStudentByClassroomID(string classroomID)
        {
            var list = _studentRepository.GetStudentByClassroomID(classroomID);
            return list;
        }

        public List<Student> GetStudentByClassroomID(Func<Student, bool> filter)
        {
            var list = _studentRepository.GetStudentByClassroomID(filter);
            return list;
        }

        public Student Insert(Student entity)
        {
            _studentRepository.Insert(entity);
            return entity;
        }

        public void Update(Student entity)
        {
            throw new NotImplementedException();
        }

        public List<Student> Where(Func<Student, bool> filter)
        {
            var list = _studentRepository.Where(filter);
            return list;
        }
    }
}
