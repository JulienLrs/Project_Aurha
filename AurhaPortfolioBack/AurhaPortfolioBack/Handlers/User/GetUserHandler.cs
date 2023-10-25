using AurhaPortfolioBack.Infrastructures.DatabaseContext;
using AurhaPortfolioBack.Models.Users;
using AurhaPortfolioBack.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AurhaPortfolioBack.Handlers.User
{
    public class GetUserHandler : IRequestHandler<GetUserByIdQuery, UserFeatures>
    {
        private readonly AurhaPortfolioContext _context;

        public GetUserHandler(AurhaPortfolioContext context)
        {
            _context = context;
        }

        public async Task<UserFeatures> Handle(GetUserByIdQuery command, CancellationToken cancellationToken)
        {
            return await _context.Users.Where(u => u.Id == command.Id).FirstAsync();
        }
    }
}
