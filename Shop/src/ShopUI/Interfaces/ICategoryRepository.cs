using ShopUI.Models.Entities;

namespace ShopUI.Interfaces;

public interface ICategoryRepository
{
    List<Category> GetAllCategories();
    void AddCategory(string catName);
}
