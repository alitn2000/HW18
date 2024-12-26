using ShopUI.Models.Entities;

namespace ShopUI.Interfaces;

public interface IProductService
{
    List<Product> GetAll();
    void Delete(int id);
}
