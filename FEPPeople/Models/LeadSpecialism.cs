﻿using System.Text.Json.Serialization;

namespace FEPPeople.Models
{
    public class LeadSpecialism
    {
        public int LeadSpecialismID { get; set; }
        public int SpecialismID { get; set; }

        [JsonIgnore]
        public Lead? Lead { get; set; }

        public Specialism? Specialism { get; set; }
    }
}
