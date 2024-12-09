using BuderDinner.Domain.Entities;

namespace BuderDinner.Application.Commom.interfaces.Persistence
{
    public interface IUserRepository
    {
        User? GetUserByEmail(string email);
        void Add(User user);
    }
}