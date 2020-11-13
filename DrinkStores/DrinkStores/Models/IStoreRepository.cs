using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkStores.Models
{
    public class IStoreRepository
    {
        private IQueryable<Product> Products { get; }
    }
}
