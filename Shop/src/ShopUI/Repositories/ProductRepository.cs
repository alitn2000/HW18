using Microsoft.EntityFrameworkCore;
using Shop.InferaStructures.DB;
using ShopUI.Interfaces;
using ShopUI.Models.Entities;

namespace ShopUI.Repositories;

public class ProductRepository : IProductRepository
{
    private ShopDB _context = new ShopDB();

    public List<Product>? GetAllProducts()
    {
        return _context.Products.Include(p => p.Category).ToList();
    }
    public void DeleteProduct(Product product)
    {
        _context.Products.Remove(product);
        _context.SaveChanges(); 
    }
}
