using CoreLayer.DataAccess.EntityFramwork;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class FooterDal : BaseRepository<Footer, ProjeContext>, IFooterDal
    {
        public List<FooterListDto> GetFooterListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Footers.Select(footer => new FooterListDto()
                {
                    Id = footer.Id,
                    Adress= footer.Adress,
                    Phone= footer.Phone,
                    Mail= footer.Mail,
                    Twiter=footer.Twiter,
                    Facebook= footer.Facebook,
                    Instegram= footer.Instegram,
                    Linkedin= footer.Linkedin,
                    Skype= footer.Skype,
                    LastUpdatedAt = footer.LastUpdatedAt,
                    CreatedFullName = footer.AppUser.Name,
                    IsActive = footer.IsActive,
                    RowOrder = footer.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
