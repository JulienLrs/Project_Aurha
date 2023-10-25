using MediatR;

namespace AurhaPortfolioBack.Commands.User
{
    public record UpdateUserCommand(int id, string? firstName, string? lastName, bool? isAdmin, string? address, string? city, string? region, string? postalCode, string? country, int? phone, string? email) : IRequest<bool>;
}