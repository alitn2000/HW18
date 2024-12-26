using ShopUI.Models.Entities;

namespace ShopUI.Interfaces
{
    public interface IProductRepository
    {
         List<Product> GetAllProducts();
        void DeleteProduct(Product product);
    }
}
