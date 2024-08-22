using Microsoft.AspNetCore.Identity;

namespace SellPainting.Models
{
    public class ApplicationUser:IdentityUser
    {

        public string FirstName { get; set; }
        public string FamilyName {  get; set; }
        public string Address {  get; set; }
        public string Role {  get; set; }

    }
}
