using AurhaPortfolioBack.Infrastructures.DatabaseContext;
using AurhaPortfolioBack.Models.Artworks;
using AurhaPortfolioBack.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AurhaPortfolioBack.Handlers.Artwork
{
    public class GetArtworkHandler : IRequestHandler<GetArtworkByIdQuery, ArtworkFeatures>
    {
        private readonly AurhaPortfolioContext _context;

        public GetArtworkHandler(AurhaPortfolioContext context)
        {
            _context = context;
        }   

        public async Task<ArtworkFeatures> Handle(GetArtworkByIdQuery command, CancellationToken cancellation)
        {
            return await _context.Artworks.Where(a => a.Id == command.Id).FirstAsync();
        }
    }
}
