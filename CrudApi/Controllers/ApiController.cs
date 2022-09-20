using CrudApi.Entity;
using CrudApi.Model;
using CrudApi.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace CrudApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ApiController : ControllerBase
    {

        private readonly IProductRepository _productRepository;

        public ApiController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpPost]
        [Route("Create-Product")]
        public bool createProduct([FromBody] ProductModel model)
        {
            try
            {
                var product = new Product()
                {
                    Name = model.Name,
                    Price = model.Price,
                };

                return _productRepository.createProduct(product);
            }
            catch
            {
                return false;
            }
        }
        [HttpDelete]
        [Route("Delete-Product")]
        public bool deleteProduct([FromBody] ProductModel model)
        {
            try
            {
                var product = new Product()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Price = model.Price,
                };
                _productRepository.deleteProduct(model.Id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpGet]
        [Route("List-Products")]

        public IEnumerable<Product> getAll()
        {
            return _productRepository.getAll();
        }
    }
}
