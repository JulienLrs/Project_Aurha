using AurhaPortfolioBack.Models.Artworks;
using MediatR;

namespace AurhaPortfolioBack.Queries
{
    public record GetArtworkByIdQuery(int Id) : IRequest<ArtworkFeatures>;
}