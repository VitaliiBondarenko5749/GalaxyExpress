using GalaxyExpress.DAL.Data;
using GalaxyExpress.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GalaxyExpress.DAL.Repositories;

public interface IGenericRepository<TEntity, TKey> where TEntity : class
{
    Task<TKey> CreateAsync(TEntity entity);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity?> GetByIdAsync(TKey key);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TKey key);
}

public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity, Guid> where TEntity : BaseEntity
{
    protected readonly GalaxyExpressDbContext dbContext;
    protected readonly DbSet<TEntity> entities;

    protected GenericRepository(
        GalaxyExpressDbContext dbContext)
    {
        this.dbContext = dbContext;
        this.entities = dbContext.Set<TEntity>();
    }


    public virtual async Task<Guid> CreateAsync (TEntity entity)
    {
        await entities.AddAsync(entity);
        return entity.Id;
    }
    
    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await entities.AsNoTracking().ToListAsync();
    }

    public virtual async Task<TEntity?> GetByIdAsync(Guid id)
    {
        return await entities.FindAsync(id);
    }

    public virtual async Task UpdateAsync(TEntity entity)
    {
        var existingEntity = await GetByIdAsync(entity.Id);

        if (existingEntity == null)
            throw new Exception($"{typeof(TEntity).Name} with id: [{entity.Id}] was not found");
        if (existingEntity.DateDeleted != null)
            throw new Exception($"{typeof(TEntity).Name} with id: [{entity.Id}] already deleted");


        dbContext.Entry(existingEntity).State = EntityState.Detached;

        entity.DateUpdated = DateTime.UtcNow;
        entity.DateCreated = existingEntity.DateCreated;
        dbContext.Entry(entity).State = EntityState.Modified;
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);

        if (entity == null)
            throw new Exception($"{typeof(TEntity).Name} with id: [{id}] was not found");
        if (entity.DateDeleted != null)
            throw new Exception($"{typeof(TEntity).Name} with id: [{id}] already deleted");

        dbContext.Entry(entity).State = EntityState.Detached;
        entity.DateDeleted = DateTime.UtcNow;
        await UpdateAsync(entity);
    }
}
