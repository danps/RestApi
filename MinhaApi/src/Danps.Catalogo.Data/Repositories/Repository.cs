using Danps.Core;

namespace Danps.Catalogo.Data
{
    public abstract class Repository<TEntity> : MyRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly CatalogoDbContext Db;

        protected Repository(CatalogoDbContext db) : base(db)
        {
            Db = db;
        }

        public override async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public override void Dispose()
        {
            Db?.Dispose();
        }
    }
}