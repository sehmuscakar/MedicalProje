using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class DoctorManager : IDoctorManager
    {
        private readonly IDoctorDal _doctorDal;
        public DoctorManager(IDoctorDal doctorDal)
        {
            _doctorDal = doctorDal;
        }
        public void Add(Doctor doctor)
        {
           doctor.AppUserId = 3;
           doctor.IsActive = true;
            var roworder = _doctorDal.GetAll().Count();
            doctor.RowOrder = roworder + 1;
            _doctorDal.Add(doctor);   
        }
        public Doctor GetByID(int id)
        {
            return _doctorDal.Get(id);
        }
        public List<DoctorListDto> GetDoctorListManager()
        {
            return _doctorDal.GetDoctorListDal();
        }
        public List<Doctor> GetList()
        {
            return _doctorDal.GetAll();
        }
        public void Remove(Doctor doctor)
        {
            _doctorDal.Delete(doctor);
        }
        public void Update(Doctor doctor)
        {
           doctor.AppUserId = 3;
           doctor.IsActive = true;
            var roworder = _doctorDal.GetAll().Count();
          doctor.RowOrder = roworder;
          doctor.LastUpdatedAt = DateTime.Now;
            _doctorDal.Update(doctor);  
        }
    }
}
