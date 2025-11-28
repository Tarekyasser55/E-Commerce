using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Shared.DataTransfareObjects.products;

namespace E_Commerce.ServiceAbstraction;

public interface IproductService
{
    Task<productResponse?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<IEnumerable<productResponse>> GetProductsAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<BrandResponse>> GetBrandsAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<TypeResponse>> GetTypesAsync(CancellationToken cancellationToken = default);
}
