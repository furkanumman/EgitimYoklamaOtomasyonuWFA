using DAL.Repositories.Base;
using DATA;

namespace DAL.Repositories
{
    public class BranchRepository : BaseRepository<Branch, int>
    {
        public bool FindBranch(Branch branch)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
            var entity = _context.Branches.FirstOrDefault(x => x.Name == branch.Name || x.Mail == branch.Mail);
            if (entity != null)
            {
                return true;
            }
            return false;
            //}
        }

        public int GetBranchIDByName(string name)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
            var branch = _context.Branches.FirstOrDefault(x => x.Name == name);
            if (branch != null)
            {
                return branch.ID;
            }
            return -1;
            //}
        }

        public string GetBranchAddressByName(string branchName)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
            var branch = _context.Branches.FirstOrDefault(x => x.Name == branchName);

            if (branch != null)
            {
                return branch.Adress;
            }
            return string.Empty;
            //}
        }

        public string GetBranchNameByID(int? branchID)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
            var entity = _context.Branches.FirstOrDefault(x => x.ID == branchID);

            if (entity != null)
                return $"{entity.Name}";
            else
                return "-";
            //}
        }
        public Branch Update(Branch branch)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                var _branchs = _context.Branches.FirstOrDefault(x => x.ID == branch.ID);
                if (_branchs != null)
                {
                    _branchs.Name = branch.Name;
                    _branchs.Phone = branch.Phone;
                    _branchs.Mail = branch.Mail;
                    _branchs.Adress = branch.Adress;
                    _context.SaveChanges();
                }
            //}
            return branch;
        }

    }
}
