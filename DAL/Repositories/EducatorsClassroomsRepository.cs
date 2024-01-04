using DAL.Repositories.Base;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EducatorsClassroomsRepository : BaseRepository<EducatorClassroom, int>
    {


        public EducatorClassroom GetEducatorClassroom(EducatorClassroom educatorsClassrooms)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
            var result = _context.EducatorsClassrooms.FirstOrDefault(x => x.ClassroomID == educatorsClassrooms.ClassroomID);
            return result;
            //            }
        }
    }
}