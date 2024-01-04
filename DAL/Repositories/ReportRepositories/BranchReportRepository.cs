using DAL.Repositories.Base;

namespace DAL.Repositories.ReportRepositories
{
    public class BranchReportRepository
    {
        protected readonly AppDbContext _context;

        public BranchReportRepository()
        {
            _context = new AppDbContext();
        }
        public int CoordinatorCountByID(int branchID)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                int countCoordinator = _context.Coordinators.Where(x => x.BranchID == branchID).Count();
                return countCoordinator;
            //}
        }
        public int EducatorCountByID(int branchID)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                int countEducator = _context.Educators.Where(x => x.BranchID == branchID).Count();
                return countEducator;
            //}
        }

        public int StudentCountByID(int branchID)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                int quantity = _context.Students.Join(_context.Classrooms, s => s.ClassroomID, c => c.ID, (s, c) => new { Students = s, Classrooms = c }).Where(x => x.Classrooms.BranchID == branchID).Count();
                return quantity;
            //}
        }

        // bir şubede verilen eğitim sayısı, eğitimler tekrar edebilir.
        public int EducationCountByID(int branchID)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                int quantity = _context.Educations.Join(_context.Classrooms, e => e.ID, c => c.EducationID, (e, c) => new { Education = e, Classrooms = c }).Where(x => x.Classrooms.BranchID == branchID).Select(x => x.Education.ID).Count();
                return quantity;
            //}
        }

        public int TotalEducationDuration(int branchID)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                int result = _context.Educations.Join(_context.Classrooms, e => e.ID, c => c.EducationID, (e, c) => new { Education = e, Classrooms = c }).Where(x => x.Classrooms.BranchID == branchID).Sum(x => x.Education.Duration);
                return result;
            //}
        }

        public decimal EducationAmountPerEducator(int branchID)
        {
            return EducationCountByID(branchID) / (decimal)EducatorCountByID(branchID);
        }
    }
}
