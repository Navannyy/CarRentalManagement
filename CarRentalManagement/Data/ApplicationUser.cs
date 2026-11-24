using Microsoft.AspNetCore.Identity;

namespace CarRentalManagement.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}