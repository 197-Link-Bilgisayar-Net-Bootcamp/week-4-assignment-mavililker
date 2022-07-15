using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment4.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public string Role { get; set; }

        
    }
}
