using CotacaoMoeda.Context;
using CrudApi.Entity;
using CrudApi.Repository.IRepository;

namespace CrudApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApiContext _context;

        public ProductRepository(ApiContext context)
        {
            _context = context;

        }

        public bool createProduct(Product product)
        {
            try
            {
                if(product.Id == 0)
                {
                    _context.Product.Add(product);
                }
                else
                {
                    _context.Product.Update(product);
                }
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Product searchById(long Id)
        {
            return _context.Product.Where(s => s.Id == Id).FirstOrDefault();
        }

        public bool deleteProduct(long Id)
        {
            _context.Product.Remove(searchById(Id));
            _context.SaveChanges();
            return true;
        }

        public List<Product> getAll()
        {
            return _context.Product.ToList();
        }

    }
}
