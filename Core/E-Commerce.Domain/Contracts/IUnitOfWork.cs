using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Domain.Entities;
using E_Commerce.Domain.Entities.products;

namespace E_Commerce.Domain.Contracts;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    IRepository<TEntity,Tkey> GetRepository<TEntity, Tkey>()
        where TEntity : Entity<Tkey>;
}
