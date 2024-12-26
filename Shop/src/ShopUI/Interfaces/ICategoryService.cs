using ShopUI.Models.Entities;

namespace ShopUI.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(string catName);
    }
}
