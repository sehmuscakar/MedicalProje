using CoreLayer.DataAccess;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IBusinessDal:IEntityRepository<Business>
    {
        List<BusinessListDto> GetBusinessListDal();

    }
}
