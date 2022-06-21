using BlzrDemoCRM.Server.Data;
using BlzrDemoCRM.Shared.Models;

namespace BlzrDemoCRM.Server.Services
{
    public static class ContactMapper
    {
        public static List<ContactDisplayModel> EntityListToDisplayModelList(List<ContactEntity> entities)
        {
            var retModels = new List<ContactDisplayModel>();
            foreach (ContactEntity entity in entities)
            {
                retModels.Add(new ContactDisplayModel
                {
                    Id = entity.Id,
                    DisplayName = entity.GetDisplayName()
                });
            }
            return retModels;
        }

        public static ContactDetailModel EntityToDetailModel(ContactEntity entity)
        {
            return new ContactDetailModel
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                MiddleName = entity.MiddleName,
                LastName = entity.LastName,
                Address = entity.Address,
                Phone = entity.Phone,
                Age = entity.Age
            };

        }

        public static ContactEntity DetailModelToEntity(ContactDetailModel model)
        {
            return new ContactEntity
            {
                Id = model.Id,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                Address = model.Address,
                Phone = model.Phone,
                Age = model.Age
            };
        }
    }
}