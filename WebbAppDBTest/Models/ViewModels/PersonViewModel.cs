using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebbAppDBTest.Models
{
    public class PersonViewModel
    {
        [Required(ErrorMessage = "Must have a Name")]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Must have a name between 1 to 60 letters long")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Must have a Phonenumber")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Phonenumber must be between 2 to 30 numbers long")]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Must have a City")]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Must have a city between 1 to 60 letters long")]
        public string City { get; set; }

    }
}
