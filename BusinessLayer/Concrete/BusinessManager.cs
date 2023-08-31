using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class BusinessManager : IBusinessManager
    {

        private readonly IBusinessDal _businessDal;

        public BusinessManager(IBusinessDal businessDal)
        {
            _businessDal = businessDal;
        }

        public void Add(Business business)
        {
           business.AppUserId = 3;
           business.IsActive = true;
            var roworder = _businessDal.GetAll().Count();
          business.RowOrder = roworder + 1;
            _businessDal.Add(business);
        }

        public List<BusinessListDto> GetBusinessListManager()
        {
            return _businessDal.GetBusinessListDal();
        }

        public Business GetByID(int id)
        {
            return _businessDal.Get(id);
        }

        public List<Business> GetList()
        {
            return _businessDal.GetAll();
        }

        public void Remove(Business business)
        {
          _businessDal.Delete(business);
        }

        public void Update(Business business)
        {
           business.AppUserId = 3;
           business.IsActive = true;
            var roworder = _businessDal.GetAll().Count();
           business.RowOrder = roworder;
           business.LastUpdatedAt = DateTime.Now;
            _businessDal.Update(business);   
        }
    }
}
