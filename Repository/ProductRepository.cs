using Microsoft.EntityFrameworkCore;
using WebApiProject.AppDbContext;

namespace WebApiProject.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppsDbContext _dbContext;

        public ProductRepository(AppsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product;
        }


        public Product GetProductById(int id)
        {
            return _dbContext.Products.FirstOrDefault(p => p.ProductId == id);
        }

        public bool UpdateProduct(Product product)
        {
            _dbContext.Products.Update(product);
            int affectedRows = _dbContext.SaveChanges();
            return affectedRows > 0;  
        }

        public bool DeleteProduct(Product product)
        {
            _dbContext.Products.Remove(product);
            int affectedRows = _dbContext.SaveChanges();
            return affectedRows > 0;  
        }


    }
}
