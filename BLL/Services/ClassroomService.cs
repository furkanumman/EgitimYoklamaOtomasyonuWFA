using BLL.Interfaces;
using DAL.Repositories;
using DATA;

namespace BLL.Services
{
    public class ClassroomService : IClassroomService
    {
        private readonly ClassroomRepository _classroomRepository;

        public ClassroomService()
        {
            _classroomRepository = new ClassroomRepository();
        }

        public bool CheckControl(Func<Classroom, bool> filter)
        {
            bool result = _classroomRepository.CheckControl(filter);
            return result;
        }

        public Classroom Delete(Classroom entity)
        {
            var classroom = _classroomRepository.Delete(entity);
            return classroom;
        }

        public List<Classroom> GetAll()
        {
            var list = _classroomRepository.GetAll();
            return list;
        }

        public Classroom GetByID(Classroom entity)
        {
            var classroom = _classroomRepository.GetByID(entity);
            return classroom;
        }

        public Classroom GetClassroomByClassroomID(string classroomID)
        {
            var entity = _classroomRepository.GetClassroomByClassroomID(classroomID);
            return entity;
        }

        public List<int> GetLessonDays(string classroomID)
        {
            var list = _classroomRepository.GetLessonDays(classroomID);
            return list;
        }

        public Classroom Insert(Classroom entity)
        {
            var classroom = _classroomRepository.Insert(entity);
            return classroom;
        }

        public void Update(Classroom entity)
        {
            _classroomRepository.Update(entity);
        }

        public List<Classroom> Where(Func<Classroom, bool> filter)
        {
            var list = _classroomRepository.Where(filter);
            return list;
        }
    }
}
