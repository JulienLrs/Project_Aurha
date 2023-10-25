using AurhaPortfolioBack.Models.Users;
using MediatR;

namespace AurhaPortfolioBack.Queries
{
    public record GetUserByIdQuery(int Id) : IRequest<UserFeatures>;
}
