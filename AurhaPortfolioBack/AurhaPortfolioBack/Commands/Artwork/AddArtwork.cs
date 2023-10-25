using AurhaPortfolioBack.Models.Artworks;
using MediatR;

namespace AurhaPortfolioBack.Commands.Artwork
{
    public record AddArtworkCommand(string name, string description, int amount, string img,CategoryFeatures category) : IRequest<bool>;
    
}
