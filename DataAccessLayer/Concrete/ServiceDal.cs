using CoreLayer.DataAccess.EntityFramwork;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class ServiceDal : BaseRepository<Service, ProjeContext>, IServiceDal
    {
        public List<ServiceListDto> GetServiceListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Services.Select(service => new ServiceListDto()
                {
                    Id = service.Id,      
                    Title = service.Title,
                    Description = service.Description,
                    İcon=service.İcon,
                    LastUpdatedAt = service.LastUpdatedAt,
                    CreatedFullName = service.AppUser.Name,
                    IsActive = service.IsActive,
                    RowOrder = service.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
