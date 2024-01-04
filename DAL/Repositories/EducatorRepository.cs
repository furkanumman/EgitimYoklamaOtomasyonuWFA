using DAL.Repositories.Base;
using DATA;

namespace DAL.Repositories
{
    public class EducatorRepository : BaseRepository<Educator, int>
    {
        public void Update(Educator educator)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                var _educator = _context.Educators.FirstOrDefault(x => x.ID == educator.ID);
                if (_educator != null)
                {
                    _educator.Name = educator.Name;
                    _educator.Surname = educator.Surname;
                    _educator.Phone = educator.Phone;
                    _educator.Email = educator.Email;
                    _educator.DateofBirth = educator.DateofBirth;
                    _educator.Photo = educator.Photo;
                    _educator.Password = educator.Password;
                    _educator.BranchID = educator.BranchID;
                    _context.SaveChanges();
                }
            //}
        }

        public List<Educator> GetByNameSurname(string nameSurname)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                var list = _context.Educators.Where(x => x.Name == nameSurname || x.Surname == nameSurname).ToList();
                return list;
            //}
        }
        public Educator GetByEmailAddress(string emailAddress)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                Educator educator = _context.Educators.FirstOrDefault(x => x.Email == emailAddress);
                return educator;
            //}
        }

        public Educator GetByID(int ID)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                Educator educator = _context.Educators.FirstOrDefault(x => x.ID == ID);
                return educator;
            //}
        }
    }
}
