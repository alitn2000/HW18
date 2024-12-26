using NuGet.Protocol.Core.Types;
using ShopUI.Interfaces;
using ShopUI.Models.Entities;
using ShopUI.Repositories;

namespace ShopUI.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository = new UserRepository();

        public void Add(string name, string userName, string pass)
        {
            User user = new User() { Name = name, UserName = userName, Password = pass};
            _userRepository.AddUser(user);
        }

        public User? LogIn(string userName, string pass)
        {
           var user = _userRepository.GetUser(userName, pass);
            

            if (user == null)
            {
                throw new Exception("Invalid username or password.");
            }
            return user;
        }

    }
}
