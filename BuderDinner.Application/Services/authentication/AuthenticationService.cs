using System;
using BuderDinner.Application.Commom.interfaces.authentication;

namespace BuderDinner.Application.Services.authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGennerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGennerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            // Registration logic here
            // ...

            Guid userId = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);

            return new AuthenticationResult(
                userId,
                firstName,
                lastName,
                email,
                token);
        }

        public AuthenticationResult Login(string email, string password)
        {
            // Login logic here
            // ...

            return new AuthenticationResult(
                Guid.NewGuid(),
                "firstName",
                "lastName",
                email,
                "token");
        }
    }
}