using BlzrDemoCRM.Server.Repositories;
using BlzrDemoCRM.Shared.Models;

namespace BlzrDemoCRM.Server.Services
{
    public class ContactService : IContactService
    {
        readonly IContactRepo _contactRepo;

        public ContactService(IContactRepo contactRepo)
        {
            _contactRepo = contactRepo;
        }

        // to List all contacts
        public List<ContactDisplayModel> ListContacts()
        {
            try
            {
                return ContactMapper.EntityListToDisplayModelList(_contactRepo.ListContactEntities().OrderBy(c => c.LastName).ToList());
            }
            catch
            {
                throw;
            }
        }

        // to get a contact
        public ContactDetailModel GetContactById(int id)
        {
            try
            {
                ContactDetailModel? contact = ContactMapper.EntityToDetailModel(_contactRepo.GetContactEntityById(id));
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
        public void AddContact(ContactDetailModel contact)
        {
            try
            {
                _contactRepo.InsertContactEntity(ContactMapper.DetailModelToEntity(contact));
            }
            catch
            {
                throw;
            }
        }

        // to Update a contact
        public void UpdateContact(ContactDetailModel contact)
        {
            try
            {
                _contactRepo.UpdateContactEntity(ContactMapper.DetailModelToEntity(contact));
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
                _contactRepo.DeleteContactEntity(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
