using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities.products
{
    public class product:Entity<int>
    {
        public string Name { set; get; } = default!;
        public string Description { set; get; } = default!;
        public string pictureUrl { set; get; } = default!;
        public decimal price { set; get; }
        public productType productType { set; get; }
        public int TypeId { set; get; }
         public productBrand productBrand { set; get; }
        public int BrandId { set; get; }
        
    }
}
