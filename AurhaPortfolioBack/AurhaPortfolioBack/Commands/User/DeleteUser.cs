using MediatR;

namespace AurhaPortfolioBack.Commands.User
{
    public record DeleteUserCommand(int id) : IRequest<bool>;
}