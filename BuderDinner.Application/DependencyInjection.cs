using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuderDinner.Application.Services.authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BuderDinner.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}
