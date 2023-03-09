using Microsoft.AspNetCore.Identity;

namespace Identity.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? ProfilePicture { get; set; }
    }
}
