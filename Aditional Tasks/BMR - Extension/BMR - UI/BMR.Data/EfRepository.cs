namespace BMR.Data
{
    using BMR.Data.Common;
    using Microsoft.EntityFrameworkCore;

    using System;
    using System.Linq;
    using System.Threading.Tasks;
    
    public class EfRepository<Entity> : IRepository<Entity>
     where Entity : class
    {
        public EfRepository(BMRDbContext context)
        {
            this.Context = context ?? throw new ArgumentNullException(nameof(context));
            this.DbSet = this.Context.Set<Entity>();
        }

        protected DbSet<Entity> DbSet { get; set; }

        protected BMRDbContext Context { get; set; }

        public virtual IQueryable<Entity> All() => this.DbSet;

        public virtual IQueryable<Entity> AllAsNoTracking() => this.DbSet.AsNoTracking();

        public virtual Task AddAsync(Entity entity) => this.DbSet.AddAsync(entity).AsTask();

        public virtual void Update(Entity entity)
        {
            var entry = this.Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public virtual void Delete(Entity entity) => this.DbSet.Remove(entity);

        public Task<int> SaveChangesAsync() => this.Context.SaveChangesAsync();

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Context?.Dispose();
            }
        }
    }
}