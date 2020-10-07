namespace SportBox7.Infrastructure.Persistence.Repositories
{
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Contracts;
    using Domain.Common;

    internal class DataRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IAggregateRoot
    {
        public DataRepository(SportBox7DbContext db) => this.Data = db;

        protected SportBox7DbContext Data { get; }

        public async Task Save(
            TEntity entity,
            CancellationToken cancellationToken = default)
        {
            this.Data.Update(entity);

            await this.Data.SaveChangesAsync(cancellationToken);
        }

        public Task<int> Save(CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        IQueryable<TEntity> IRepository<TEntity>.All()
        {
            return this.Data.Set<TEntity>();
        }
    }
}
