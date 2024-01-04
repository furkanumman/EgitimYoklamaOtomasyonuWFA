using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.ReportRepositories
{
    public class GeneralReportRepository 
    {
        private readonly AppDbContext context;

        public GeneralReportRepository()
        {
            context = new AppDbContext();   
        }
        private int Count<T>(Func<AppDbContext, DbSet<T>> dbSetSelector) where T : class
        {
            using (AppDbContext context = new AppDbContext())
            {
                DbSet<T> dbSet = dbSetSelector(context);
                if (dbSet != null)
                {
                    int count = dbSet.Count();
                    return count;
                }
            }
            return 0;
        }

        public int CountAdministrator()
        {
            return Count(context => context.Administrators);
        }

        public int CountBranch()
        {
            return Count(context => context.Branches);
        }

        public int CountCoordinator()
        {
            return Count(context => context.Coordinators);
        }

        public int CountEducator()
        {
            return Count(context => context.Educators);
        }

        public int CountStudent()
        {
            return Count(context => context.Students);
        }

        public int CountEducation()
        {
            return Count(context => context.Educations);
        }

        public int TotalEducationDuration()
        {
            using (AppDbContext context = new AppDbContext())
            {
                if (context.Educations.Count() != null)
                {
                    int duration = context.Educations.Sum(x => x.Duration);
                    return duration;
                }
            }
            return 0;

        }
    }
}
