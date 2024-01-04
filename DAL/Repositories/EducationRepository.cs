using DAL.Repositories.Base;
using DATA;

namespace DAL.Repositories
{
    public class EducationRepository : BaseRepository<Education, int>
    {
        public void Update(Education newEducation)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                Education education = _context.Educations.Find(newEducation.ID);

                if (education != null)
                {
                    education.Name = newEducation.Name;
                    education.Description = newEducation.Description;
                    education.Duration = newEducation.Duration;
                    _context.SaveChanges();
                }
            //}
        }

        public Education FindEducation(Education education)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                Education entity = _context.Educations.FirstOrDefault(x => x.ID == education.ID || x.Name == education.Name);//Name == education.Name && x.Duration == education.Duration && x.Description == education.Description);
                return entity;
            //}
        }

        public Education FindIDByNameDuration(string name, int duration)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                var entity = _context.Educations.FirstOrDefault(x => x.Name == name && x.Duration == duration);
                if (entity != null)
                {
                    return entity;
                }
                throw new Exception("Eğitim bulunamadı!");
            //}
        }
        public int GetEducationID(Education education)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                var getEducation = _context.Educations.FirstOrDefault(x => x.Name == education.Name && x.Duration == education.Duration && x.Description == education.Description);
                if (getEducation != null)
                {
                    return getEducation.ID;
                }
                return -1;
            //}
        }


    }
}
