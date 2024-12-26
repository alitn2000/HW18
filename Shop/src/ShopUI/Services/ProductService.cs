using ShopUI.Interfaces;
using ShopUI.Models.Entities;
using ShopUI.Repositories;

namespace ShopUI.Services
{
    public class ProductService : IProductService
    {
        IProductRepository _repository = new ProductRepository();
        public List<Product> GetAll()
        {
            if (_repository.GetAllProducts() == null)
            {
                throw new NullReferenceException("Error");
            }
            return _repository.GetAllProducts();
        }
        public void Delete(int id)
        {
            var product = _repository.GetAllProducts().FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _repository.DeleteProduct(product); 
            }
        }
    }
}
