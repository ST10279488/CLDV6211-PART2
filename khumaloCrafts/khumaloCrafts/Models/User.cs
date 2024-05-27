namespace khumaloCrafts.Models
{
    public class User
    {
        internal string? Email;
        internal string? UserName;

        public int UserId { get; set; }
            public required string Name { get; set; }
            public required string Address { get; set; }

        internal class Users : Models.User
        {
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
            public required string UserName { get; set; }
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
            public new required string Email { get; set; }
        }
    }

    }

