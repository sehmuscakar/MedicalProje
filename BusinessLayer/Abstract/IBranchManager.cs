using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IBranchManager
    {

        List<BranchListDto> GetBranchListManager();
        List<Branch> GetList();
        void Add(Branch branch);

        void Update(Branch branch);

        void Remove(Branch branch);

        Branch GetByID(int id);
    }
}
