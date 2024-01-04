using BLL.Interfaces.Base;
using DATA;

namespace BLL.Interfaces
{
    public interface IBranchService : IBaseService<Branch, int>
    {
        public int GetBranchIDByName(string name);

        public string GetBranchNameByID(int? branchID);

        public bool FindBranch(Branch branch);

        public string GetBranchAddressByName(string branchName);

    }
}
