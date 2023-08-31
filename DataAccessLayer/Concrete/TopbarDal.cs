using CoreLayer.DataAccess.EntityFramwork;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class TopbarDal : BaseRepository<Topbar, ProjeContext>, ITopbarDal
    {
        public List<TopbarListDto> GetTopbarListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Topbars.Select(topbar => new TopbarListDto()
                {
                    Id= topbar.Id,
                   Mail=topbar.Mail,
                   Phone=topbar.Phone,
                   SocialMedia1= topbar.SocialMedia1,
                   SocialMedia2= topbar.SocialMedia2,
                   SocialMedia3= topbar.SocialMedia3,
                   SocialMedia4= topbar.SocialMedia4,
                   LastUpdatedAt = topbar.LastUpdatedAt,
                   CreatedFullName = topbar.AppUser.Name,//bunu topbar appuser ilişkisinden userdan çektik
                   IsActive = topbar.IsActive,
                   RowOrder = topbar.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
