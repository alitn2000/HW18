using Shop.InferaStructures.DB;
using ShopUI.Interfaces;
using ShopUI.Models.Entities;

namespace ShopUI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ShopDB _context = new ShopDB();

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User? GetUser(string userName, string pass)
        {
            return _context.Users.Where(u => u.UserName == userName && u.Password == pass).FirstOrDefault();
        }
    }
}
