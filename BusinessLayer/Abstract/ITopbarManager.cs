using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITopbarManager
    {
        List<TopbarListDto> GetTopbarListManager();
        List<Topbar> GetList();
        void Add(Topbar topbar);

        void Update(Topbar topbar);

        void Remove(Topbar topbar);

        Topbar GetByID(int id);

    }
}
