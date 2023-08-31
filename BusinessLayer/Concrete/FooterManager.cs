using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class FooterManager : IFooterManager
    {
        private readonly IFooterDal _footerDal;

        public FooterManager(IFooterDal footerDal)
        {
            _footerDal = footerDal;
        }

        public void Add(Footer footer)
        {
            footer.AppUserId = 3;
            footer.IsActive = true;
            var roworder = _footerDal.GetAll().Count();
            footer.RowOrder = roworder + 1;
           _footerDal.Add(footer);  
        }

        public Footer GetByID(int id)
        {
          return  _footerDal.Get(id);
        }

        public List<FooterListDto> GetFooterListManager()
        {
            return _footerDal.GetFooterListDal();
        }

        public List<Footer> GetList()
        {
            return _footerDal.GetAll();
        }

        public void Remove(Footer footer)
        {
            _footerDal.Delete(footer);
        }

        public void Update(Footer footer)
        {
           footer.AppUserId = 3;
           footer.IsActive = true;
           var roworder = _footerDal.GetAll().Count();
           footer.RowOrder = roworder;
           footer.LastUpdatedAt = DateTime.Now;
            _footerDal.Update(footer);
        }
    }
}
