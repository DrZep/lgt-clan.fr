using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace lgt.clan.fr.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Comments { get; set; }
        public Byte[] Avatar { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime? DateOfModification { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string Guid { get; set; }
        public bool IsActive { get; set; }
        public bool IsBan { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber1 { get; set; }
    }
}
