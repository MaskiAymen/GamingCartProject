using Microsoft.AspNetCore.Identity;

namespace GamingCart.Models
{
        public class AppUser : IdentityUser
        {
                public string Occupation { get; set; }
        }
}
