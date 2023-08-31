using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class WhyUsManager :IWhyUsManager
    {

        private readonly IWhyUsDal _whyUsDal;

        public WhyUsManager(IWhyUsDal whyUsDal)
        {
            _whyUsDal = whyUsDal;
        }

        public void Add(WhyUs whyUs)
        {
            whyUs.AppUserId = 3;
            whyUs.IsActive = true;
            var roworder = _whyUsDal.GetAll().Count();
            whyUs.RowOrder = roworder + 1;
            _whyUsDal.Add(whyUs);
        }

        public WhyUs GetByID(int id)
        {
           return _whyUsDal.Get(id);
        }

        public List<WhyUs> GetList()
        {
           return _whyUsDal.GetAll();
        }

        public List<WhyUsListDto> GetWhyUsListManager()
        {
            return _whyUsDal.GetWhyUsListDal();
        }

        public void Remove(WhyUs whyUs)
        {
            _whyUsDal.Delete(whyUs);
        }
        public void Update(WhyUs whyUs)
        {
            whyUs.AppUserId = 3;
            whyUs.IsActive = true;
            var roworder = _whyUsDal.GetAll().Count();
          whyUs.RowOrder = roworder;
          whyUs.LastUpdatedAt = DateTime.Now;
            _whyUsDal.Update(whyUs);
        }
    }
}
