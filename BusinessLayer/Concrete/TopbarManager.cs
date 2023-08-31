using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class TopbarManager : ITopbarManager
    {
        private readonly ITopbarDal _topbarDal; //dependis enjekjın yaptım ,constractır uyguladık/yapıcı foksiyon

        public TopbarManager(ITopbarDal topbarDal)
        {
            _topbarDal = topbarDal;
        }

        public void Add(Topbar topbar)
        {
           topbar.AppUserId = 3; // token ile bu id yerine otantike olan kişin name ini getirtebilirsin
           topbar.IsActive = true;
            var roworder = _topbarDal.GetAll().Count();
            topbar.RowOrder = roworder + 1;
            _topbarDal.Add(topbar);
        }

        public Topbar GetByID(int id)
        {
          return _topbarDal.Get(id);
        }

        public List<Topbar> GetList()
        {
           return _topbarDal.GetAll();
        }

        public List<TopbarListDto> GetTopbarListManager()
        {
            var listele = _topbarDal.GetTopbarListDal();
            return listele;
        }

        public void Remove(Topbar topbar)
        {
            _topbarDal.Delete(topbar);
        }

        public void Update(Topbar topbar)
        {
           topbar.AppUserId = 3;
           topbar.IsActive = true;
            var roworder = _topbarDal.GetAll().Count();
            topbar.RowOrder = roworder;
            topbar.LastUpdatedAt = DateTime.Now;
            _topbarDal.Update(topbar);
        }
    }
}
