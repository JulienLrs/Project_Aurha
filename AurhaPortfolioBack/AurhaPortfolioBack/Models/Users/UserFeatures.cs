using System.ComponentModel.DataAnnotations;
using AurhaPortfolioBack.Models.Artworks;

namespace AurhaPortfolioBack.Models.Users
{
    public class UserFeatures
    {
        [Key]
        public int Id { get; set; }

        // Data Annotation Attributes
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        public bool isAdmin { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? Region { get; set; }

        public string? PostalCode { get; set; }

        public string? Country { get; set; }

        public int? Phone { get; set; }
        [Required]
        public string Email { get; set; }

        public ICollection<ArtworkFeatures> Artworks { get; set; }
    }
}
