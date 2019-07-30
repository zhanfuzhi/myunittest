using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace myproject.EntityFramework.Repositories
{
    public abstract class myprojectRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<myprojectDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected myprojectRepositoryBase(IDbContextProvider<myprojectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class myprojectRepositoryBase<TEntity> : myprojectRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected myprojectRepositoryBase(IDbContextProvider<myprojectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
