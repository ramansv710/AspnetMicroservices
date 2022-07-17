using Catalog.API.Entities;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        Task CreateProduct(Product product);
        Task<bool> DeleteProduct(string id);
        Task<Product> GetProduct(string id); 
        Task<IEnumerable<Product>> GetProducts();        
        Task<IEnumerable<Product>> GetProductByCategory(string categoryName);
        Task<IEnumerable<Product>> GetProductByName(string name);                
        Task<bool> UpdateProduct(Product product);
    }
}