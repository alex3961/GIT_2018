using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ProjectAlex.EntityFramework.Repositories
{
    public abstract class ProjectAlexRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ProjectAlexDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ProjectAlexRepositoryBase(IDbContextProvider<ProjectAlexDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ProjectAlexRepositoryBase<TEntity> : ProjectAlexRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ProjectAlexRepositoryBase(IDbContextProvider<ProjectAlexDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
