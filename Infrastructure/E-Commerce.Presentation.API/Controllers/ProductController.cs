using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.ServiceAbstraction;
using E_Commerce.Shared.DataTransfareObjects.products;
using Microsoft.AspNetCore.Mvc;
namespace E_Commerce.Presentation.API.Controllers;

public class ProductController(IproductService service) : APIBaseController
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<productResponse>>> GetProducts(CancellationToken cancellationToken = default)
    {
        var Response = await service.GetProductsAsync(cancellationToken);
        return Ok(Response);
    }

    [HttpGet("{Id}")]
    public async Task<ActionResult<productResponse>> Get(int Id, CancellationToken cancellationToken = default)
    {
        var Response = await service.GetByIdAsync(Id, cancellationToken);
        return Ok(Response);
    }
    [HttpGet("Brands")]
    public async Task<ActionResult<IEnumerable<TypeResponse>>> GetBrands(CancellationToken cancellationToken = default)
    {
        var Response = await service.GetBrandsAsync(cancellationToken);
        return Ok(Response);
    }

    [HttpGet("Types")]
    public async Task<ActionResult<IEnumerable<TypeResponse>>> GetTypes(CancellationToken cancellationToken = default)
    {
        var Response = await service.GetTypesAsync(cancellationToken);
        return Ok(Response);
    }
}
