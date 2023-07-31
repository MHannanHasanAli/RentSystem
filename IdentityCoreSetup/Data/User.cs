using Microsoft.AspNetCore.Identity;

namespace IdentityCoreSetup.Data
{
    public class User: IdentityUser
    {
        public string? Name { get; set; }
        public string? ProfilePicture { get; set; }
    }
}
