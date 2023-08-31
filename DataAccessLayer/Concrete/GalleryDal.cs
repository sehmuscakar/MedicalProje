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
    public class GalleryDal : BaseRepository<Gallery, ProjeContext>, IGalleryDal
    {
        public List<GalleryListDto> GetGalleryListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Galleries.Select(galeri => new GalleryListDto()
                {
                    Id = galeri.Id,
              ImageUrl= galeri.ImageUrl,
                    LastUpdatedAt = galeri.LastUpdatedAt,
                    CreatedFullName = galeri.AppUser.Name,
                    IsActive = galeri.IsActive,
                    RowOrder = galeri.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
