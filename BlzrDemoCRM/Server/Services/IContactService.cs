using BlzrDemoCRM.Shared.Models;

namespace BlzrDemoCRM.Server.Services
{
    public interface IContactService
    {
        public List<ContactDisplayModel> ListContacts();
        public ContactDetailModel GetContactById(int id);
        public void AddContact(ContactDetailModel contact);
        public void UpdateContact(ContactDetailModel contact);
        public void RemoveContact(int id);

    }
}
