using BlzrDemoCRM.Shared.Models;

namespace BlzrDemoCRM.Server.Interfaces
{
    public interface IContact
    {
        public List<Contact> ListContacts();
        public Contact GetContactById(int id);
        public void AddContact(Contact contact);
        public void UpdateContact(Contact contact);
        public void RemoveContact(int id);

    }
}
