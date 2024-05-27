using Microsoft.AspNetCore.Identity;

namespace khumaloCrafts.Models
{
   
        using Microsoft.AspNetCore.Identity;

public class Users : IdentityUser
    {
        public required string Address { get; set; }
    }

}

