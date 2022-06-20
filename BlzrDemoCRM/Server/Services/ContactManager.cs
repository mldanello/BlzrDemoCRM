using BlzrDemoCRM.Server.Interfaces;
using BlzrDemoCRM.Server.Models;
using BlzrDemoCRM.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlzrDemoCRM.Server.Services
{
    public class ContactManager : IContact
    {
        readonly DatabaseContext _dbContext = new();
        public ContactManager(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        // to List all contacts
        public List<Contact> ListContacts()
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
        public Contact GetContactById(int id)
        {
            try
            {
                Contact? contact = _dbContext.Contacts.Find(id);
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
        public void AddContact(Contact contact)
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
        public void UpdateContact(Contact contact)
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
        public void RemoveContact(int id)
        {
            try
            {
                Contact? contact = _dbContext.Contacts.Find(id);
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
