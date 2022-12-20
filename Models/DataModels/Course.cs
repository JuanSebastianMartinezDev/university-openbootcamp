using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Course: BaseEntity
    {
        [Required, StringLength(100)]
        public string Name = string.Empty;

        public string LongDescription = string.Empty;

        [StringLength(280)]
        public string ShortDescription = string.Empty;

        public string PublicObjetive = string.Empty;

        public string Objetives = string.Empty;

        public string Requisites = string.Empty;

        [Required]
        public int Level; 
    }
}
