using AurhaPortfolioBack.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace AurhaPortfolioBack.Models.Artworks
{
        public class ArtworkFeatures
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public string Name { get; set; }

            public string? Description { get; set; }

            public int? Amount { get; set; }
            [Required]
            public string Img { get; set; }

            public CategoryFeatures category { get; set; }

            public ICollection<UserFeatures>? Users { get; set; }
        }
    
}
