using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuderDinner.Application.Commom.interfaces.authentication;
using BuderDinner.Application.Commom.interfaces.Services;
using BuderDinner.Application.Services.authentication;
using BuderDinner.Infrastructure.Authentication;
using BuderDinner.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BuderDinner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGennerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}