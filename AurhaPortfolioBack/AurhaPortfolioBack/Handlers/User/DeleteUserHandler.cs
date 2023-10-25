using AurhaPortfolioBack.Commands.User;
using AurhaPortfolioBack.Infrastructures.RepositoryBase;
using MediatR;

namespace AurhaPortfolioBack.Handlers.User
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly IRepositoryWrapper _context;

        public DeleteUserHandler(IRepositoryWrapper context) => _context = context;

        public Task<bool> Handle(DeleteUserCommand command, CancellationToken cancellationToken)
        {
            var toDelete = _context.User.FindByCondition(u => u.Id == command.id).First();

            _context.User.Delete(toDelete);

            return Task.FromResult(true);

        }
    }
}
