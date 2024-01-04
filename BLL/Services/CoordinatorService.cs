using BLL.Interfaces;
using BLL.Interfaces.Base;
using DAL.Repositories;
using DATA;

namespace BLL.Services
{
    public class CoordinatorService : ICoordinatorService
    {

        private readonly CoordinatorRepository _coordinatorRepository;

        public CoordinatorService()
        {
            _coordinatorRepository = new CoordinatorRepository();
        }

        public Coordinator Insert(Coordinator entity)
        {
            var coordinator = _coordinatorRepository.Insert(entity);
            return coordinator;
        }

        public void Update(Coordinator entity)
        {
            _coordinatorRepository.Update(entity);
        }

        public Coordinator Delete(Coordinator entity)
        {
            var returnCoordinator = _coordinatorRepository.Delete(entity);
            return returnCoordinator;
        }
        public List<Coordinator> GetAll()
        {
            var list = _coordinatorRepository.GetAll();
            return list;
        }

        public Coordinator GetByID(Coordinator entity)
        {
            var result = _coordinatorRepository.GetByID(entity);
            return result;
        }


        public bool CheckControl(Func<Coordinator, bool> filter)
        {
            bool result = _coordinatorRepository.CheckControl(filter);
            return result;
        }

        public List<Coordinator> Where(Func<Coordinator, bool> filter)
        {
            var list = _coordinatorRepository.Where(filter);
            return list;
        }

        public Coordinator GetByEmailAddress(string eMailAddress)
        {
            var result = _coordinatorRepository.GetByEmailAddress(eMailAddress);
            return result;
        }

        public bool HaveCoordinatoraBranch(int coordinatorID)
        {
            bool result = _coordinatorRepository.HaveCoordinatoraBranch(coordinatorID);
            return result;
        }

        Educator IUserBaseService<Educator, int>.GetByEmailAddress(string emailAddress)
        {
            throw new NotImplementedException();
        }

        public List<Educator> GetByNameSurname(string nameSurname)
        {
            throw new NotImplementedException();
        }

        public void UpdateBranchByCoordinatorId(int branchID, int coordinatorID)
        {
            _coordinatorRepository.UpdateBranchByCoordinatorId(branchID, coordinatorID);
        }

        public string FindByBranchID(int branchID)
        {
            string result = _coordinatorRepository.FindByBranchID(branchID);
            return result;
        }
    }
}
