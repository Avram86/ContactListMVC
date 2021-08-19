using ContactListMVC.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactListMVC.Models
{
    public class ContactListEntry
    {
        [Key]
        public int Id { get; set; }
        public ContactType ContactType { get; set; }
        [MaxLength(200, ErrorMessage = "Name must be less than 200 characters")]
        public string Name { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        [DisplayName("Date of birth")]
        public DateTime? DateOfBirth { get; set; } = null;
        [MaxLength(1000, ErrorMessage = "Address must be less than 1000 characters")]
        public string Address { get; set; } = string.Empty;
       
        [MaxLength(50, ErrorMessage = "Phone must be less than 50 characters")]
        [RegularExpression("^[0-9]*$")]
        public string Phone { get; set; } = string.Empty;
        [DataType(DataType.EmailAddress)]
        [MaxLength(200, ErrorMessage ="Email must be less than 200 characters")]
        public string Email { get; set; } = string.Empty;

    }
}
