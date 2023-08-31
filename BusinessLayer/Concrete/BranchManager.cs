using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BranchManager : IBranchManager
    {

        private readonly IBranchDal _branchDal;

        public BranchManager(IBranchDal branchDal)
        {
            _branchDal = branchDal;
        }

        public void Add(Branch branch)
        {
            branch.AppUserId = 3; 
            branch.IsActive = true;
            var roworder = _branchDal.GetAll().Count();
            branch.RowOrder = roworder + 1;
            _branchDal.Add(branch);
        }

        public List<BranchListDto> GetBranchListManager()
        {
            return _branchDal.GetBranchListDal();
        }

        public Branch GetByID(int id)
        {
            return _branchDal.Get(id);
        }

        public List<Branch> GetList()
        {
            return _branchDal.GetAll();
        }

        public void Remove(Branch branch)
        {
            _branchDal.Delete(branch);
        }

        public void Update(Branch branch)
        {
           branch.AppUserId = 3;
           branch.IsActive = true;
            var roworder = _branchDal.GetAll().Count();
           branch.RowOrder = roworder;
           branch.LastUpdatedAt = DateTime.Now;
            _branchDal.Update(branch);
        }
    }
}
