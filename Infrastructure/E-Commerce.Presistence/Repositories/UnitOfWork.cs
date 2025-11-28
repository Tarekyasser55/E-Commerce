using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Presistence.Repositories;

internal class UnitOfWork(AplicationDbContext dbContext) : IUnitOfWork
{
    private readonly Dictionary<string, object> _reposiitories = [];
    public IRepository<TEntity, Tkey> GetRepository<TEntity, Tkey>() where TEntity : Entity<Tkey>
    {
        var typeName = typeof(TEntity).Name;
        if (_reposiitories.TryGetValue(typeName, out object? value))
            return (value as IRepository<TEntity, Tkey>)!;
        var repo = new Repository<TEntity, Tkey>(dbContext);
        _reposiitories.Add(typeName, repo);
        return repo;
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    => await dbContext.SaveChangesAsync(cancellationToken);
}
