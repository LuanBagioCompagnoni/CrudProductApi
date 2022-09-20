using CrudApi.Entity;

namespace CrudApi.Repository.IRepository
{
    public interface IProductRepository
    {

        bool createProduct(Product product);

        Product searchById(long Id);

        bool deleteProduct(long Id);

        List<Product> getAll();

    }
}
