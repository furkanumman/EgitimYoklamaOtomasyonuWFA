using DAL.Repositories.Base;
using DATA;

namespace DAL.Repositories
{
    public class AdministratorRepository : BaseRepository<Administrator, int>
    {
        public void Update(Administrator administrator)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                var _administrator = _context.Administrators.FirstOrDefault(x => x.ID == administrator.ID);
                if (_administrator != null)
                {
                    _administrator.Name = administrator.Name;
                    _administrator.Surname = administrator.Surname;
                    _administrator.Phone = administrator.Phone;
                    _administrator.Email = administrator.Email;
                    _administrator.DateofBirth = administrator.DateofBirth;
                    _administrator.Photo = administrator.Photo;
                    _administrator.Password = administrator.Password;
                    _context.SaveChanges();
                }
            //}
        }


        public Administrator GetByEmailAddress(string emailAddress)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
            Administrator administrator = _context.Administrators.FirstOrDefault(x => x.Email == emailAddress);
            return administrator;
            //}
        }

        public List<Administrator> GetByNameSurname(string nameSurname)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
            var list = _context.Administrators.Where(x => x.Name == nameSurname || x.Surname == nameSurname).ToList();
            return list;
            //}
        }
    }
}

