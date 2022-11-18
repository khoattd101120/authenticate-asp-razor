using Microsoft.AspNetCore.Identity;

namespace authenticate_asp_razor.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set;}
    }
}
