using MediatR;

namespace AurhaPortfolioBack.Commands.Category
{
    public record DeleteCategoryCommand(int id) : IRequest<bool>;
}


