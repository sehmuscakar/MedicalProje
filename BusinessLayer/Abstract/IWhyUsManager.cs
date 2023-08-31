using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface IWhyUsManager
    {
        List<WhyUsListDto> GetWhyUsListManager();
        List<WhyUs> GetList();
        void Add(WhyUs whyUs);

        void Update(WhyUs whyUs);

        void Remove(WhyUs whyUs);

       WhyUs GetByID(int id);
    }
}
