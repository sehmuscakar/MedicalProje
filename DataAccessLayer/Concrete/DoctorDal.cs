using CoreLayer.DataAccess.EntityFramwork;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class DoctorDal : BaseRepository<Doctor, ProjeContext>, IDoctorDal
    {
        public List<DoctorListDto> GetDoctorListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Doctors.Select(doctor => new DoctorListDto()
                {
                    Id = doctor.Id,
                    ImageUrl= doctor.ImageUrl,
                    FullName= doctor.FullName,
                    Branch= doctor.Branch,
                    Description= doctor.Description,
                    SocialMedia1= doctor.SocialMedia1,
                    SocialMedia2= doctor.SocialMedia2,
                    SocialMedia3= doctor.SocialMedia3,
                    SocialMedia4= doctor.SocialMedia4,
                    LastUpdatedAt = doctor.LastUpdatedAt,
                    CreatedFullName = doctor.AppUser.Name,
                    IsActive = doctor.IsActive,
                    RowOrder = doctor.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
