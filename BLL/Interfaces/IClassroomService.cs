using BLL.Interfaces.Base;
using DATA;

namespace BLL.Interfaces
{
    public interface IClassroomService : IBaseService<Classroom, string>
    {
        public Classroom GetClassroomByClassroomID(string classroomID);

        public List<int> GetLessonDays(string classroomID);
    }
}
