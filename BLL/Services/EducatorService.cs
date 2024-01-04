using BLL.Interfaces;
using DAL.Repositories;
using DATA;

namespace BLL.Services
{

    public class EducatorService : IEducatorService
    {
        private readonly EducatorRepository _educatorRepository;

        public EducatorService()
        {
            _educatorRepository = new EducatorRepository();
        }
        public bool CheckControl(Func<Educator, bool> filter)
        {
            bool result = _educatorRepository.CheckControl(filter);
            return result;
        }

        public Educator Delete(Educator entity)
        {
            var educator = _educatorRepository.Delete(entity);
            return educator;
        }

        public List<Educator> GetAll()
        {
            var list = _educatorRepository.GetAll();
            return list;
        }

        public Educator GetByEmailAddress(string eMailAddress)
        {
            var result = _educatorRepository.GetByEmailAddress(eMailAddress);
            return result;
        }

        public Educator GetByID(Educator entity)
        {
            var result = _educatorRepository.GetByID(entity);
            return result;
        }

        public List<Educator> GetByNameSurname(string nameSurname)
        {
            throw new NotImplementedException();
        }

        public Educator Insert(Educator entity)
        {
            var educator = _educatorRepository.Insert(entity);
            return educator;
        }

        public void Update(Educator entity)
        {
            _educatorRepository.Update(entity);
        }

        public List<Educator> Where(Func<Educator, bool> filter)
        {
            var list = _educatorRepository.Where(filter);
            return list;
        }
    }
}
