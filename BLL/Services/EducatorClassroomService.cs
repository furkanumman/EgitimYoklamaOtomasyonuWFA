using BLL.Interfaces;
using DAL.Repositories;
using DATA;

namespace BLL.Services
{
    public class EducatorClassroomService : IEducatorClassroomService
    {

        private readonly EducatorsClassroomsRepository _repository;

        public EducatorClassroomService()
        {
            _repository = new EducatorsClassroomsRepository();
        }
        public EducatorClassroom Insert(EducatorClassroom entity)
        {
            var educatorClassroom = _repository.Insert(entity);
            return educatorClassroom;
        }

        public bool CheckControl(Func<EducatorClassroom, bool> filter)
        {
            throw new NotImplementedException();
        }

        public EducatorClassroom Delete(EducatorClassroom entity)
        {
            throw new NotImplementedException();
        }

        public List<EducatorClassroom> GetAll()
        {
            throw new NotImplementedException();
        }

        public EducatorClassroom GetByID(EducatorClassroom entity)
        {
            throw new NotImplementedException();
        }

        public void Update(EducatorClassroom entity)
        {
            throw new NotImplementedException();
        }

        public List<EducatorClassroom> Where(Func<EducatorClassroom, bool> filter)
        {
            var list = _repository.Where(filter);
            return list;
        }

        public EducatorClassroom GetEducatorClassroom(EducatorClassroom educatorsClassrooms)
        {
            var entity = _repository.GetEducatorClassroom(educatorsClassrooms);
            return entity;
        }
    }
}
