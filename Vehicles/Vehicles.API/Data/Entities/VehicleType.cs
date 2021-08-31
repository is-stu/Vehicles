using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Data.Entities
{
    public class VehicleType
    {
        public int id { get; set; }

        [Display(Name = "Vehicle type")]
        [MaxLength(50, ErrorMessage = "The field {0} just allow {1} characters")]
        [Required(ErrorMessage = "The field {0} is required")] 
        public string description { get; set; }
    }
}
