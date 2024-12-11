using BuderDinner.Application.Commom.interfaces.Persistence;
using BuderDinner.Domain.Entities;

namespace BuderDinner.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new();

        public User? GetUserByEmail(string email)
        {
            return _users.SingleOrDefault(u => u.Email == email);
        }

        public void Add(User user)
        {
            _users.Add(user);
        }
    }
}
