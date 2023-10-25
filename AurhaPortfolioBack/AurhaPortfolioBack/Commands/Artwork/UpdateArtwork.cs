using AurhaPortfolioBack.Models.Artworks;
using MediatR;

namespace AurhaPortfolioBack.Commands.Artwork
{
    public record UpdateArtworkCommand(int id, string? name, string? description, int? amount, string? img, CategoryFeatures category) : IRequest<bool>;
}
