using CoreLayer.DataAccess.EntityFramwork;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class WhyUsDal : BaseRepository<WhyUs, ProjeContext>, IWhyUsDal
    {
        public List<WhyUsListDto> GetWhyUsListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.WhyUs.Select(WhyUs => new WhyUsListDto()
                {
                    Id = WhyUs.Id,
                    Header= WhyUs.Header,
                    HeaderDescription = WhyUs.HeaderDescription,
                    Title1 = WhyUs.Title1,
                    TitleDecription1= WhyUs.TitleDecription1,
                    Title2 = WhyUs.Title2,
                    TitleDecription2 = WhyUs.TitleDecription2,
                    Title3= WhyUs.Title3,
                    TitleDecription3 = WhyUs.Title3,
                    LastUpdatedAt = WhyUs.LastUpdatedAt,
                    CreatedFullName = WhyUs.AppUser.Name,
                    IsActive = WhyUs.IsActive,
                    RowOrder = WhyUs.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
