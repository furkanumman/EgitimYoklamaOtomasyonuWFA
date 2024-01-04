using DAL.Repositories.Base;
using DATA;

namespace DAL.Repositories
{
    public class CoordinatorRepository : BaseRepository<Coordinator, int>
    {

        public void Update(Coordinator coordinator)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
            var _coordinator = _context.Coordinators.FirstOrDefault(x => x.ID == coordinator.ID);
            if (_coordinator != null)
            {
                _coordinator.Name = coordinator.Name;
                _coordinator.Surname = coordinator.Surname;
                _coordinator.Phone = coordinator.Phone;
                _coordinator.Email = coordinator.Email;
                _coordinator.DateofBirth = coordinator.DateofBirth;
                _coordinator.Photo = coordinator.Photo;
                _coordinator.Password = coordinator.Password;
                _coordinator.BranchID = coordinator.BranchID;
                _context.SaveChanges();
            }
        }


        public List<Coordinator> GetByNameSurname(string nameSurname)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
            var list = _context.Coordinators.Where(x => x.Name == nameSurname || x.Surname == nameSurname).ToList();
            return list;
            //}
        }
        public Coordinator GetByEmailAddress(string emailAddress)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
            Coordinator coordinator = _context.Coordinators.FirstOrDefault(x => x.Email == emailAddress);
            return coordinator;

            //}

        }
        public void UpdateBranchByCoordinatorId(int branchID, int coordinatorID)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                Coordinator coordinator = _context.Coordinators.FirstOrDefault(x => x.ID == coordinatorID);
                if (coordinator != null)
                {
                    coordinator.BranchID = branchID;
                    _context.SaveChanges();
                }
            //}
        }
        public bool HaveCoordinatoraBranch(int coordinatorID)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                Coordinator coordinator = _context.Coordinators.FirstOrDefault(x => x.ID == coordinatorID);
                if (coordinator.BranchID != null)
                {
                    return true;
                }
                return false;
            //}
        }

        public string FindByBranchID(int branchID)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                var entity = _context.Coordinators.FirstOrDefault(x => x.BranchID == branchID);

                if (entity != null)
                    return $"{entity.ID}-{entity.Name} {entity.Surname}";
                else
                    return "-";
            //}
        }

        public List<Coordinator> GetByBranchID(int branchID)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                List<Coordinator> coordinators = _context.Coordinators.Where(x => x.BranchID == branchID).ToList();

                if (coordinators != null)
                    return coordinators;
                else
                    return coordinators = new List<Coordinator>();
            //}
        }
    }
}

