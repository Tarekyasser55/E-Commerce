using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities.products
{
    public class productBrand : Entity<int>
    {
        public string Name { set; get; } = default!;

    }
}
