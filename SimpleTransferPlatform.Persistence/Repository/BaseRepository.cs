using Microsoft.EntityFrameworkCore;
using SimpleTransferPlatform.Domain.Entities;
using SimpleTransferPlatform.Domain.Interfaces;
using SimpleTransferPlatform.Persistence.Context;

namespace SimpleTransferPlatform.Persistence.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext Context;

        public BaseRepository(AppDbContext context)
        {
            Context = context;
        }


        public void Create(T entity)
        {
            entity.SetCreated();
            Context.Add(entity);
        }

        public void Delete(T entity)
        {
            entity.SetDeleted();
            Context.Remove(entity);
        }

        public void Update(T entity)
        {
            entity.SetModified();
            Context.Update(entity);
        }
        public async Task<T> GetById(Guid id, CancellationToken cancellationToken)
        {
            return await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken)
        {
            return await Context.Set<T>().ToListAsync(cancellationToken);
        }

    }
}
