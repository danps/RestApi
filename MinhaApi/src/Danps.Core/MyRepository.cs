using Danps.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Danps.Core
{
    public abstract class MyRepository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    { 
        protected readonly DbSet<TEntity> DbSet;
        protected MyRepository(DbContext db)
        {
            DbSet = db.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<TEntity> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<List<TEntity>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Atualizar(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }

        public virtual async Task Remover(Guid id)
        {
            DbSet.Remove(new TEntity { Id = id });
            await SaveChanges();
        }
        public abstract Task<int> SaveChanges();
        public abstract void Dispose();
    }
}