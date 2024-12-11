using BuderDinner.Api.Filters;
using BuderDinner.Api.Middleware;
using BuderDinner.Application;
using BuderDinner.Application.Services.authentication;
using BuderDinner.Infrastructure;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);


{
    builder.Services.AddApplication().AddInfrastructure(builder.Configuration);

    // builder.Services.AddControllers(Options => Options.Filters.Add<ErrorHandlingFilterAtribute>());
    builder.Services.AddControllers();
}
var app = builder.Build();


{
    app.Map("/error", (HttpContext httpContext)=>
    {
        Exception? exception = httpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        return Results.Problem();
    });
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
