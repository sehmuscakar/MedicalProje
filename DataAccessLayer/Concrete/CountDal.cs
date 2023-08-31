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
    public class CountDal : BaseRepository<Count, ProjeContext>, ICountDal
    {
        public List<CountListDto> GetCountListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Counts.Select(count => new CountListDto()
                {
                    Id = count.Id,
                  Doctors= count.Doctors,
                  Departments= count.Departments,
                  ReserarchLabs= count.ReserarchLabs,
                  Awards= count.Awards,
                    LastUpdatedAt = count.LastUpdatedAt,
                    CreatedFullName = count.AppUser.Name,
                    IsActive = count.IsActive,
                    RowOrder = count.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
