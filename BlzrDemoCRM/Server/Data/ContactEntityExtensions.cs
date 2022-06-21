namespace BlzrDemoCRM.Server.Data
{
    public static class ContactEntityExtensions
    {
        public static string GetDisplayName(this ContactEntity contactEntity)
        {
            return string.Concat(
                contactEntity.FirstName != null ? contactEntity.FirstName : string.Empty,
                contactEntity.MiddleName != null ? " " + contactEntity.MiddleName + " " : " ",
                contactEntity.LastName != null ? contactEntity.LastName : string.Empty
                );
        }
    }
}
