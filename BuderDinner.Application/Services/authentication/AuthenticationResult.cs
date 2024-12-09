using System;
using BuderDinner.Domain.Entities; // Assuming User is defined in this namespace

namespace BuderDinner.Application.Services.authentication
{
    public record AuthenticationResult(User user, string Token);
}