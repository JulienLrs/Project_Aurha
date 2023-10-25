using AurhaPortfolioBack.Commands.User;
using AurhaPortfolioBack.Infrastructures.RepositoryBase;
using AurhaPortfolioBack.Models.Users;
using MediatR;

namespace AurhaPortfolioBack.Handlers.User
{
    public class AddUserHandler : IRequestHandler<AddUserCommand, bool>
    {
        private readonly IRepositoryWrapper _context;

        public AddUserHandler(IRepositoryWrapper context) => _context = context;

        public Task<bool> Handle(AddUserCommand command, CancellationToken cancellationToken)
        {

            _context.User.Create(new UserFeatures() { FirstName = command.firstName, LastName = command.lastName, isAdmin = command.isAdmin, Email = command.email, Address = command.address, City = command.city, Region = command.region, PostalCode = command.postalCode, Country = command.country, Phone = command.phone });

            return Task.FromResult(true);

        }
    }
}
