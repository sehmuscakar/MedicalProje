using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IBusinessManager
    {
        List<BusinessListDto> GetBusinessListManager();
        List<Business> GetList();
        void Add(Business business);

        void Update(Business business);

        void Remove(Business business);

        Business GetByID(int id);
    }
}
