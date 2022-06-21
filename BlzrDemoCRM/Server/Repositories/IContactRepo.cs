using BlzrDemoCRM.Server.Data;

namespace BlzrDemoCRM.Server.Repositories

{
    public interface IContactRepo
    {
        public List<ContactEntity> ListContactEntities();
        public ContactEntity GetContactEntityById(int id);
        public void InsertContactEntity(ContactEntity contactEntity);
        public void UpdateContactEntity(ContactEntity contactEntity);
        public void DeleteContactEntity(int id);

    }
}
