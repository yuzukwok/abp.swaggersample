using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SwaggerSample.EntityFramework.Repositories
{
    public abstract class SwaggerSampleRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SwaggerSampleDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SwaggerSampleRepositoryBase(IDbContextProvider<SwaggerSampleDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SwaggerSampleRepositoryBase<TEntity> : SwaggerSampleRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SwaggerSampleRepositoryBase(IDbContextProvider<SwaggerSampleDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
