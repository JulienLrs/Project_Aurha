using AurhaPortfolioBack.Commands.Artwork;
using AurhaPortfolioBack.Infrastructures.RepositoryBase;
using MediatR;

namespace AurhaPortfolioBack.Handlers.Artwork
{
    public class UpdateArtworkHandler : IRequestHandler<UpdateArtworkCommand, bool>
    {
        private readonly IRepositoryWrapper _context;

        public UpdateArtworkHandler(IRepositoryWrapper context) => _context = context;

        public Task<bool> Handle(UpdateArtworkCommand command, CancellationToken cancellationToken)
        {
            var toUpdate = _context.Artwork.FindByCondition(a => a.Id == command.id).First();

            toUpdate.Name = command.name ?? toUpdate.Name;
            toUpdate.Description = command.description ?? toUpdate.Description;
            toUpdate.Amount = command.amount ?? toUpdate.Amount;
            toUpdate.Img = command.img ?? toUpdate.Img;
            toUpdate.category = command.category ?? toUpdate.category;

            _context.Artwork.Update(toUpdate);

            return Task.FromResult(true);
        }
    }
}
