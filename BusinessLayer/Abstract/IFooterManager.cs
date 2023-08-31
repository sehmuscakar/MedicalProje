using DataAccessLayer.Dtos;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IFooterManager
    {
        List<FooterListDto> GetFooterListManager();
        List<Footer> GetList();
        void Add(Footer footer);
        void Update(Footer footer);
        void Remove(Footer footer);
        Footer GetByID(int id);
    }
}
