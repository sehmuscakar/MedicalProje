using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICountManager
    {
        List<CountListDto> GetCountListManager();
        List<Count> GetList();
        void Add(Count count);

        void Update(Count count);

        void Remove(Count count);

        Count GetByID(int id);

    }
}
