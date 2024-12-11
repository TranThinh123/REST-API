using System;
using BuderDinner.Application.Commom.interfaces.authentication;
using BuderDinner.Application.Commom.interfaces.Persistence;
using BuderDinner.Domain.Entities;

namespace BuderDinner.Application.Services.authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGennerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public AuthenticationService(
            IJwtTokenGennerator jwtTokenGenerator,
            IUserRepository userRepository
        )
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public AuthenticationResult Register(
            string firstName,
            string lastName,
            string email,
            string password
        )
        {
            if (_userRepository.GetUserByEmail(email) is not null)
            {
                throw new Exception("Email already exists.");
            }
            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password,
            };
            _userRepository.Add(user);

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(user, token);
        }

        public AuthenticationResult Login(string email, string password)
        {
            if (_userRepository.GetUserByEmail(email) is not User user)
            {
                throw new Exception("User with given email does not exist.");
            }
            if (user.Password != password)
            {
                throw new Exception("Invalid password");
            }
            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(user, token);
        }
    }
}
