using Microsoft.EntityFrameworkCore;
using Shop.InferaStructures.DB;
using ShopUI.Interfaces;
using ShopUI.Models.Entities;

namespace ShopUI.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private ShopDB _context = new ShopDB();

    public void AddCategory(string catName)
    {
        Category category = new Category();
        category.CatName = catName;
       _context.Add(category);
        _context.SaveChanges();
    }

    public List<Category> GetAllCategories()
    {
        return _context.Categories.ToList();
    }
}
