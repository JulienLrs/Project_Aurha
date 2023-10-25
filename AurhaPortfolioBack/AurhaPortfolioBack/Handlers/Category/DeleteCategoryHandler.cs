using AurhaPortfolioBack.Commands.Category;
using AurhaPortfolioBack.Infrastructures.RepositoryBase;
using MediatR;

namespace AurhaPortfolioBack.Handlers.Category
{
    public class DeleteCategoryHandler : IRequestHandler<DeleteCategoryCommand, bool>
    {
        private readonly IRepositoryWrapper _context;

        public DeleteCategoryHandler(IRepositoryWrapper context) => _context = context;

        public Task<bool> Handle(DeleteCategoryCommand command, CancellationToken cancellationToken)
        {
            var toDelete = _context.Category.FindByCondition(c => c.Id == command.id).First();

            _context.Category.Delete(toDelete);

            return Task.FromResult(true);
        }
    }
}
