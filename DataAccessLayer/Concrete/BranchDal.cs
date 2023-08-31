using CoreLayer.DataAccess.EntityFramwork;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class BranchDal : BaseRepository<Branch, ProjeContext>, IBranchDal
    {
        public List<BranchListDto> GetBranchListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.branches.Select(branch => new BranchListDto()
                {
                    Id = branch.Id,
                    TabIndex=branch.TabIndex,
                    Header= branch.Header,
                    Title= branch.Title,
                    Description= branch.Description,
                    ImageUrl= branch.ImageUrl,
                    LastUpdatedAt = branch.LastUpdatedAt,
                    CreatedFullName = branch.AppUser.Name,//bunu topbar appuser ilişkisinden userdan çektik
                    IsActive = branch.IsActive,
                    RowOrder = branch.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
