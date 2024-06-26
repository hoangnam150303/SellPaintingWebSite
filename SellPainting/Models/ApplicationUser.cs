using Microsoft.AspNetCore.Identity;

namespace SellPainting.Models
{
    public class ApplicationUser:IdentityUser
    {

        public string Name { get; set; }
    }
}
