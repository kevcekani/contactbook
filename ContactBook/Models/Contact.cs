using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactBook.Models
{
    public class Contact
    {
        [Key, Required]
        public int UserId { get; set; }

        [StringLength(15, MinimumLength = 3)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(15, MinimumLength = 3)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^([\+]?(?:00)?[0-9]{1,3}[\s.-]?[0-9]{1,12})([\s.-]?[0-9]{1,4}?)$")]
        public string Phone { get; set; }

        [StringLength(60, MinimumLength = 10)]
        [Required]
        public string Address { get; set; }
    }
}