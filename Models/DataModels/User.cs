using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class User: BaseEntity
    {
        [Required, StringLength(100)]
        public string Name = string.Empty;

        [Required, StringLength(100)]
        public string LastName = string.Empty;

        [Required, EmailAddress]
        public string Email = string.Empty;

        [Required]
        public string Password = string.Empty;

    }
}
