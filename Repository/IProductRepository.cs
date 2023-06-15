using WebApiProject.AppDbContext;

namespace WebApiProject.Repository
{
    public interface IProductRepository
    {

        IEnumerable<Product> GetAllProducts();

        Product AddProduct(Product product);

        Product GetProductById(int id);

        bool UpdateProduct(Product product);

        bool DeleteProduct(Product product);
    }
}
