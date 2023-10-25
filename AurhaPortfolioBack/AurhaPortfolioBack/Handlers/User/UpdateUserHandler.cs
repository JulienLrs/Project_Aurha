using AurhaPortfolioBack.Commands.User;
using AurhaPortfolioBack.Infrastructures.RepositoryBase;
using AurhaPortfolioBack.Models.Users;
using MediatR;

namespace AurhaPortfolioBack.Handlers.User
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, bool>
    {

        private readonly IRepositoryWrapper _context;

        public UpdateUserHandler(IRepositoryWrapper context) => _context = context;

        public Task<bool> Handle(UpdateUserCommand command, CancellationToken cancellationToken)
        {
            var toUpdate = _context.User.FindByCondition(u => u.Id == command.id).First();

            toUpdate.FirstName = command.firstName ?? toUpdate.FirstName;
            toUpdate.LastName = command.lastName ?? toUpdate.LastName;
            toUpdate.Phone = command.phone ?? toUpdate.Phone;
            toUpdate.Address = command.address ?? toUpdate.Address;
            toUpdate.City = command.city ?? toUpdate.City;
            toUpdate.Region = command.region ?? toUpdate.Region;
            toUpdate.PostalCode = command.postalCode ?? toUpdate.PostalCode;
            toUpdate.Country = command.country ?? toUpdate.Country;
            toUpdate.Email = command.email ?? toUpdate.Email;
            toUpdate.isAdmin = command.isAdmin ?? toUpdate.isAdmin;

            _context.User.Update(toUpdate);

            return Task.FromResult(true);

        }

    }
}
