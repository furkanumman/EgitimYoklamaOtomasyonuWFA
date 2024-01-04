using BLL.Interfaces;
using DAL.Repositories;
using DATA;

namespace BLL.Services
{
    public class AdministratorService : IAdministratorService
    {
        private readonly AdministratorRepository _administratorRepository;

        public AdministratorService()
        {
            _administratorRepository = new AdministratorRepository();
        }

        public bool CheckControl(Func<Administrator, bool> filter)
        {
            bool result = _administratorRepository.CheckControl(filter);
            return result;
        }

        public Administrator Delete(Administrator entity)
        {
            var administrator = _administratorRepository.Delete(entity);
            return administrator;
        }

        public List<Administrator> GetAll()
        {
            var list = _administratorRepository.GetAll();
            return list;
        }

        public Administrator GetByEmailAddress(string emailAddress)
        {
            var result = _administratorRepository.GetByEmailAddress(emailAddress);
            return result;
        }

        public Administrator GetByID(Administrator entity)
        {
            var result = _administratorRepository.GetByID(entity);
            return result;
        }

        public List<Administrator> GetByNameSurname(string nameSurname)
        {
            var list = _administratorRepository.GetByNameSurname(nameSurname);
            return list;
        }

        public Administrator Insert(Administrator entity)
        {
            var administrator = _administratorRepository.Insert(entity);
            return administrator;
        }

        public void Update(Administrator entity)
        {
            //_administratorRepository.Update(entity);
        }

        public List<Administrator> Where(Func<Administrator, bool> filter)
        {
            var list = _administratorRepository.Where(filter);
            return list;
        }
    }
}
