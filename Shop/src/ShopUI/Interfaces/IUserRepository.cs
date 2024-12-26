using ShopUI.Models.Entities;

namespace ShopUI.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        User? GetUser(string userName, string pass);
    }
}
