using System.ComponentModel.DataAnnotations;

namespace FEPPeople.Models
{
    public class ContractDay
    {
        public int ContractDayID { get; set; }

        [Required]
        public int ContractID { get; set; }

        [Range(1, 7, ErrorMessage = "Day must be between 1 and 7")]
        [Required]
        public int DayID { get; set; }
    }
}
