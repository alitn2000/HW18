using ShopUI.Models.Entities;

namespace ShopUI.Interfaces;

public interface IUserService
{
     void Add(string name, string userName, string pass);
    User LogIn (string userName, string pass);
}
