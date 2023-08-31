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
    public class BusinessDal : BaseRepository<Business, ProjeContext>, IBusinessDal
    {
        public List<BusinessListDto> GetBusinessListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Businesses.Select(business => new BusinessListDto()
                {
                    Id = business.Id,
                    About= business.About,
                    AboutDecription= business.AboutDecription,
                    Mission= business.Mission,
                    MissionDescription= business.MissionDescription,
                    Vision= business.Vision,
                    VisionDescription= business.VisionDescription,
                    ImageUrl = business.ImageUrl,
                    LastUpdatedAt = business.LastUpdatedAt,
                    CreatedFullName = business.AppUser.Name,
                    IsActive = business.IsActive,
                    RowOrder = business.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
