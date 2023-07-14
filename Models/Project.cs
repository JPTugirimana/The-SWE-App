using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sweapp.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? LinkUrl { get; set; }
        public string? ImageUrl { get; set;}

        [ForeignKey("AppUser")]
        public string? AppUserId { get; set;}
    }
}
