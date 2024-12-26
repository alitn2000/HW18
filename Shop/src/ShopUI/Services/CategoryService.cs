using ShopUI.Interfaces;
using ShopUI.Models.Entities;
using ShopUI.Repositories;

namespace ShopUI.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _repository = new CategoryRepository();

        public void Add(string catName)
        {
            _repository.AddCategory(catName);
        }

        public List<Category> GetAll()
        {

            if (_repository.GetAllCategories() == null)
            {
                throw new NullReferenceException("NullError");
            }
            return _repository.GetAllCategories();
        }
    }
}
