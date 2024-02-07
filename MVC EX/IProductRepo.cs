using MVC_EX.Models;

namespace MVC_EX
{
    public interface IProductRepo
    {
        string? GetAllProduct(int id);
        public IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);
        public void UpdateProduct(Product product);
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
        public void DeleteProduct(Product product);
    }

    
}

