using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class CountManager : ICountManager
    {
        private readonly ICountDal _countDal;

        public CountManager(ICountDal countDal)
        {
            _countDal = countDal;
        }

        public void Add(Count count)
        {
            count.AppUserId = 3;
            count.IsActive = true;
            var roworder = _countDal.GetAll().Count();
           count.RowOrder = roworder + 1;
            _countDal.Add(count);
        }

        public Count GetByID(int id)
        {
            return _countDal.Get(id);
        }

        public List<CountListDto> GetCountListManager()
        {
            return _countDal.GetCountListDal();
        }
        public List<Count> GetList()
        {
            return _countDal.GetAll();
        }
        public void Remove(Count count)
        {
            _countDal.Delete(count);
        }
        public void Update(Count count)
        {
           count.AppUserId = 3;
           count.IsActive = true;
            var roworder = _countDal.GetAll().Count();
           count.RowOrder = roworder;
           count.LastUpdatedAt = DateTime.Now;
            _countDal.Update(count);
        }
    }
}
