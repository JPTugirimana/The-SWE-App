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
        private string? linkUrl;
        private string? imageUrl;

        [ForeignKey("AppUser")]
        public string? AppUserId { get; set;}

        [Display(Name = "Project Link")]
        public string LinkUrl
        {
            get { return linkUrl; }

            set
            {
                if (IsValidUrl(value))
                    linkUrl = value;
                else
                    linkUrl = "Link NOT provided!";
            }
        }

        public string ImageUrl
        {
            get { return imageUrl; }

            set
            {
                if (IsValidUrl(value))
                    imageUrl = value;
                else
                    imageUrl = "Link NOT provided!";
            }
        }

        public static bool IsValidUrl(string url)
        {
            return Uri.IsWellFormedUriString(url, UriKind.Absolute);
        }

    }
}
