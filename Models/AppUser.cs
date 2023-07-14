using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Net;

namespace sweapp.Models
{
    public class AppUser: IdentityUser
    {
        public string? ProfileImageUrl { get; set; }
        public string? CompanyName { get; set; }
        public string? GithubUrl { get; set; }
        public string? LinkedInUrl { get; set; }
        public string? ResumeUrl { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
