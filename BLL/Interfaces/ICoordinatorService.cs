using BLL.Interfaces.Base;
using DATA;

namespace BLL.Interfaces
{
    public interface ICoordinatorService : IBaseService<Coordinator, int>
                                         , IUserBaseService<Educator, int>
    {
        public bool HaveCoordinatoraBranch(int coordinatorID);

        public void UpdateBranchByCoordinatorId(int branchID, int coordinatorID);

        public string FindByBranchID(int branchID);
    }
}
