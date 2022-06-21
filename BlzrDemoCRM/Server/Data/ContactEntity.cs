using System.ComponentModel.DataAnnotations.Schema;

namespace BlzrDemoCRM.Server.Data
{
    [Table("Contact")]
    public class ContactEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Age { get; set; }

    }
}
