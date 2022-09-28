using CrudApi.Entity;
using CrudApi.Model;

namespace CrudApi.Repository.IRepository
{
    public interface IProductRepository
    {

        bool createProduct(Product product);

        Product searchById(long Id);

        bool deleteProduct(long Id);

        IEnumerable<Product> getAll();

    }
}
