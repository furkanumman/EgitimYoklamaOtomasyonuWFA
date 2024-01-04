using BLL.Interfaces;
using DAL.Repositories;
using DATA;

namespace BLL.Services
{
    public class BranchService : IBranchService
    {
        private readonly BranchRepository _branchRepository;
        public BranchService()
        {
            _branchRepository = new BranchRepository();
        }
        public bool CheckControl(Func<Branch, bool> filter)
        {
            bool result = _branchRepository.CheckControl(filter);
            return result;
        }

        public Branch Delete(Branch entity)
        {
            var branch = _branchRepository.Delete(entity);
            return branch;
        }

        public bool FindBranch(Branch branch)
        {
            bool result = _branchRepository.FindBranch(branch);
            return result;
        }

        public List<Branch> GetAll()
        {
            var list = _branchRepository.GetAll();
            return list;
        }

        public string GetBranchAddressByName(string branchName)
        {
            string result = _branchRepository.GetBranchAddressByName(branchName);
            return result;
        }

        public int GetBranchIDByName(string name)
        {
            int result = _branchRepository.GetBranchIDByName(name);
            return result;
        }

        public string GetBranchNameByID(int? branchID)
        {
            string result = _branchRepository.GetBranchNameByID(branchID);
            return result;
        }

        public Branch GetByID(Branch entity)
        {
            var branch = _branchRepository.GetByID(entity);
            return branch;
        }

        public Branch Insert(Branch entity)
        {
            var branch = _branchRepository.Insert(entity);
            return branch;
        }

        public void Update(Branch entity)
        {
            _branchRepository.Update(entity);
        }

        public List<Branch> Where(Func<Branch, bool> filter)
        {
            var list = _branchRepository.Where(filter);
            return list;
        }
    }
}
