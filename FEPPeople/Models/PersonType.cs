using System.ComponentModel.DataAnnotations;

namespace FEPPeople.Models
{
    public class PersonType
    {
        public int PersonTypeID { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public bool IsEnabled { get; set; }
    }
}
