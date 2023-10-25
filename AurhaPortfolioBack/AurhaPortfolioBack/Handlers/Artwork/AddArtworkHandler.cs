using AurhaPortfolioBack.Commands.Artwork;
using AurhaPortfolioBack.Infrastructures.RepositoryBase;
using AurhaPortfolioBack.Models.Artworks;
using MediatR;

namespace AurhaPortfolioBack.Handlers.Artwork
{
    public class AddArtworkHandler : IRequestHandler<AddArtworkCommand, bool>
    {
        private readonly IRepositoryWrapper _context;

        public AddArtworkHandler(IRepositoryWrapper context) => _context = context;

        public Task<bool> Handle(AddArtworkCommand command, CancellationToken cancellationToken)
        {
            _context.Artwork.Create(new ArtworkFeatures() { Name = command.name, Description = command.description, Amount = command.amount, Img = command.img,category=command.category });  
            
            return Task.FromResult(true);
        }
    }
}
