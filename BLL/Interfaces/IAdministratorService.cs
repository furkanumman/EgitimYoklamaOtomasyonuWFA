using BLL.Interfaces.Base;
using DATA;

namespace BLL.Interfaces
{
    public interface IAdministratorService : IBaseService<Administrator, int>
                                           , IUserBaseService<Administrator, int>
    {

    }
}
