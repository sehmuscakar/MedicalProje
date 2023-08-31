using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface IDoctorManager
    {
        List<DoctorListDto> GetDoctorListManager();
        List<Doctor> GetList();
        void Add(Doctor doctor);

        void Update(Doctor doctor);

        void Remove(Doctor doctor);

        Doctor GetByID(int id);
    }
}
