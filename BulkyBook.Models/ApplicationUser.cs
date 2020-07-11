using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BulkyBook.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string  City { get; set; }
        public string  State { get; set; }
        public string PostalCode { get; set; }

        public int? CompanyId { get; set; } //this means this field can be null now!

        [ForeignKey("CompanyId")] public Company Company { get; set; }

        [NotMapped] // will not be pushed to the database.
        public string  Role { get; set; }
    }
}
