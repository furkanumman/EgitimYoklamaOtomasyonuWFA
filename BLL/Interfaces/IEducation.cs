using BLL.Interfaces.Base;
using DATA;

namespace BLL.Interfaces
{
    public interface IEducation : IBaseService<Education, int>
    {
        public Education FindEducation(Education education);

        public int GetEducationID(Education education);

        public Education FindIDByNameDuration(string name, int duration);
    }
}
