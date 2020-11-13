using System.Linq;


namespace DrinkStores.Models
{
    public class EFStoreRespository : IStoreRepository
    {
        private StoreDbContext context;
        public EFStoreRespository(StoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
