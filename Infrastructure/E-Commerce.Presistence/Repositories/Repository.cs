using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Domain.Entities;
using E_Commerce.Presistence.Context;

namespace E_Commerce.Presistence.Repositories;

internal class Repository<TEntity, TKey>(AplicationDbContext DbContex ) : IRepository<TEntity, TKey>
    where TEntity :Entity<TKey>
{
    public void Add(TEntity entity)
    => DbContex.Set<TEntity>().Add(entity);

    public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default)
      => await DbContex.Set<TEntity>().ToListAsync(cancellationToken);

    public async Task<TEntity?> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
        => await DbContex.Set<TEntity>().FindAsync(id,cancellationToken);

    public void Remove(TEntity entity)
     => DbContex.Set<TEntity>().Remove(entity);

    public void Update(TEntity entity)
     => DbContex.Set<TEntity>().Update(entity);
}
