using System.Linq.Expressions;
using AurhaPortfolioBack.Models.Artworks;
using AurhaPortfolioBack.Models.Users;

namespace AurhaPortfolioBack.Infrastructures.RepositoryBase
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }

    /* USER CLASSES */

    public interface IUserRepository : IRepositoryBase<UserFeatures>
    {
    }

    public interface IArtworkRepository : IRepositoryBase<ArtworkFeatures>
    {
    }

    public interface ICategoryRepository : IRepositoryBase<CategoryFeatures>
    {
    }

    /* WRAPPER */

    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        IArtworkRepository Artwork { get; }
        ICategoryRepository Category { get; }
        void Save();
    }
}

