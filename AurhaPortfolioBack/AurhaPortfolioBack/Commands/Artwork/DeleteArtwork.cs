using MediatR;

namespace AurhaPortfolioBack.Commands.Artwork
{
    public record DeleteArtworkCommand(int id) : IRequest<bool>;
}
