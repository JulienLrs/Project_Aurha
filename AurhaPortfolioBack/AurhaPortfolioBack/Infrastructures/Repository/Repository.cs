using AurhaPortfolioBack.Infrastructures.RepositoryBase;
using AurhaPortfolioBack.Infrastructures.DatabaseContext;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using AurhaPortfolioBack.Models.Users;
using AurhaPortfolioBack.Models.Artworks;

namespace AurhaPortfolioBack.Infrastructures.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected AurhaPortfolioContext RepositoryContext { get; set; }
        public RepositoryBase(AurhaPortfolioContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }
        public IQueryable<T> FindAll() => RepositoryContext.Set<T>().AsNoTracking();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
            RepositoryContext.Set<T>().Where(expression).AsNoTracking();

        public void Create(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
            RepositoryContext.SaveChanges();
        }

        public void Update(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
            RepositoryContext.SaveChanges();
        }
        public void Delete(T entity)
        { 
            RepositoryContext.Set<T>().Remove(entity);
            RepositoryContext.SaveChanges();
        }
    }

    public class UserRepository : RepositoryBase<UserFeatures>, IUserRepository
    {
        public UserRepository(AurhaPortfolioContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }

    public class ArtworkRepository : RepositoryBase<ArtworkFeatures>, IArtworkRepository
    {
        public ArtworkRepository(AurhaPortfolioContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }

    public class CategoryRepository : RepositoryBase<CategoryFeatures>, ICategoryRepository
    {
        public CategoryRepository(AurhaPortfolioContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }


    public class RepositoryWrapper : IRepositoryWrapper
    {
        private AurhaPortfolioContext _repoContext;
        private IUserRepository _user;
        private IArtworkRepository _artwork;
        private ICategoryRepository _category;

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_repoContext);
                }
                return _user;
            }
        }
        public IArtworkRepository Artwork
        {
            get
            {
                if (_artwork == null)
                {
                    _artwork = new ArtworkRepository(_repoContext);
                }
                return _artwork;
            }
        }
        public ICategoryRepository Category
        {
            get
            {
                if (_category == null)
                {
                    _category = new CategoryRepository(_repoContext);
                }
                return _category;
            }
        }
        public RepositoryWrapper(AurhaPortfolioContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
