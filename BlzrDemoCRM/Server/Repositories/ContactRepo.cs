using BlzrDemoCRM.Server.Data;

using Microsoft.EntityFrameworkCore;

namespace BlzrDemoCRM.Server.Repositories
{
    public class ContactRepo : IContactRepo
    {
        readonly DatabaseContext _dbContext = new();
        public ContactRepo(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        // to List all contacts
        public List<ContactEntity> ListContactEntities()
        {
            try
            {
                return _dbContext.Contacts.ToList();
            }
            catch
            {
                throw;
            }
        }

        // to get a contact
        public ContactEntity GetContactEntityById(int id)
        {
            try
            {
                ContactEntity? contact = _dbContext.Contacts.Find(id);
                if (contact != null)
                {
                    return contact;
                }
                else
                {
                    throw new ApplicationException($"Could not find Contact for Id: {id}");
                }
            }
            catch
            {
                throw;
            }
        }


        // to Add new contact
        public void InsertContactEntity(ContactEntity contact)
        {
            try
            {
                _dbContext.Contacts.Add(contact);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        // to Update a contact
        public void UpdateContactEntity(ContactEntity contact)
        {
            try
            {
                _dbContext.Entry(contact).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }


        // to remove a contact
        public void DeleteContactEntity(int id)
        {
            try
            {
                ContactEntity? contact = _dbContext.Contacts.Find(id);
                if (contact != null)
                {
                    _dbContext.Contacts.Remove(contact);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ApplicationException($"Could not find Contact for Id: {id}");
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
