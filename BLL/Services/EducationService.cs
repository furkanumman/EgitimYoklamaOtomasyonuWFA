using BLL.Interfaces;
using DAL.Repositories;
using DATA;

namespace BLL.Services
{
    public class EducationService : IEducation
    {
        private readonly EducationRepository _educationRepository;

        public EducationService()
        {
            _educationRepository = new EducationRepository();
        }

        public bool CheckControl(Func<Education, bool> filter)
        {
            bool result = _educationRepository.CheckControl(filter);
            return result;
        }

        public Education Delete(Education entity)
        {
            var education = _educationRepository.Delete(entity);
            return education;
        }

        public Education FindEducation(Education education)
        {
            var entity = _educationRepository.FindEducation(education);
            return entity;
        }

        public Education FindIDByNameDuration(string name, int duration)
        {
            var entity = _educationRepository.FindIDByNameDuration(name, duration);
            return entity;
        }

        public List<Education> GetAll()
        {
            var list = _educationRepository.GetAll();
            return list;
        }

        public Education GetByID(Education entity)
        {
            var education = _educationRepository.GetByID(entity);
            return education;
        }

        public int GetEducationID(Education education)
        {
            int result = _educationRepository.GetEducationID(education);
            return result;
        }

        public Education Insert(Education entity)
        {
            var education = _educationRepository.Insert(entity);
            return education;
        }

        public void Update(Education entity)
        {
            _educationRepository.Update(entity);
        }

        public List<Education> Where(Func<Education, bool> filter)
        {
            var list = _educationRepository.Where(filter);
            return list;
        }
    }
}
