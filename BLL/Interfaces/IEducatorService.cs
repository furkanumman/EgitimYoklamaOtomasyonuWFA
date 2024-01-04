using BLL.Interfaces.Base;
using DATA;

namespace BLL.Interfaces
{
    public interface IEducatorService : IBaseService<Educator, int>
                                      , IUserBaseService<Educator, int>
    {

    }
}
