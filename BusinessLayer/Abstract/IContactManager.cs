using DataAccessLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface IContactManager
    {
        List<Contact> GetList();
        void Add(Contact contact);

        void Update(Contact contact);

        void Remove(Contact contact);

        Contact GetByID(int id);
    }
}
