using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonquestKreations.Models
{
    public class EnquiryFormEntry
    {
        [Key]
        public int EnquiryID { get; set; }
        [Required]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "The characters ':', '.' ';', '*', '/' and '\' are not allowed")]
        [StringLength(40, ErrorMessage = "Name cannot be longer than 40 characters.")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "The characters ':', '.' ';', '*', '/' and '\' are not allowed")]
        public string Message { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public long PhoneNumber { get; set; }
    } 
}
