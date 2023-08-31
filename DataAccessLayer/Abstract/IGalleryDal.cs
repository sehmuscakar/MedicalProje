using CoreLayer.DataAccess;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IGalleryDal:IEntityRepository<Gallery>
    {
        List<GalleryListDto> GetGalleryListDal();
    }
}
