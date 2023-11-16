using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AuthenticationAndAuthorization.Models
{
    public class User:IdentityUser
    {
        [Required]
        public string FirstName { get; set; } =string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
