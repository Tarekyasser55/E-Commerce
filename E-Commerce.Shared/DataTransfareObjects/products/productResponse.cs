using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Shared.DataTransfareObjects.products;

public record productResponse(int id, string Name,string Description,string PictureUrl,decimal price,string Brand,string Type);

