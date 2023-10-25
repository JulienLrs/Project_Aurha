using AurhaPortfolioBack.Models.Artworks;
using AurhaPortfolioBack.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace AurhaPortfolioBack.Infrastructures.DatabaseContext
{
    public class AurhaPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=NEOS-NBK835;Database=AurhaPortfolio;Trusted_Connection=True;Encrypt=False");
        }

        public AurhaPortfolioContext(DbContextOptions<AurhaPortfolioContext> options) : base(options)
        {

        }
        public DbSet<UserFeatures> Users { get; set; }

        public DbSet<ArtworkFeatures> Artworks { get; set; }

        public DbSet<CategoryFeatures> Categories { get; set; }

    }
}
