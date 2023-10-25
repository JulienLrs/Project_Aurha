using AurhaPortfolioBack.Commands.Artwork;
using AurhaPortfolioBack.Infrastructures.RepositoryBase;
using MediatR;

namespace AurhaPortfolioBack.Handlers.Artwork
{
    public class DeleteArtworkHandler : IRequestHandler<DeleteArtworkCommand, bool>
    {
        private readonly IRepositoryWrapper _context;

        public DeleteArtworkHandler(IRepositoryWrapper context) => _context = context;

        public Task<bool> Handle(DeleteArtworkCommand command, CancellationToken cancellationToken)
        {
            var toDelete = _context.Artwork.FindByCondition(a => a.Id == command.id).First();

            _context.Artwork.Delete(toDelete);

            return Task.FromResult(true);
        }
    }
}
