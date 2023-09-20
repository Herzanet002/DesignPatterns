using Decorator;
using Decorator.Decorators;
using Decorator.Handlers;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = CreateHost();

var userHandler = new UsersRequestUserRequestHandler();
var validatorDecorator = new UserRequestsValidatorDecorator(userHandler);
var cacheDecorator = new UsersRequestsCacheDecorator(validatorDecorator,
    ActivatorUtilities.GetServiceOrCreateInstance<IMemoryCache>(host.Services));

var validUserRequest = new UserRequest(DateTime.Now, true, 1);
var validCachedUserRequest = new UserRequest(DateTime.Now, true, 1);
var expiredUserRequest = new UserRequest(DateTime.Now.AddMinutes(-5), true, 2);
var unauthenticatedUserRequest = new UserRequest(DateTime.Now, false, 3);

try
{
    await cacheDecorator.HandleRequest(validUserRequest);
    await cacheDecorator.HandleRequest(validCachedUserRequest);
}
catch (Exception e)
{
}

try
{
    await cacheDecorator.HandleRequest(expiredUserRequest);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    await cacheDecorator.HandleRequest(unauthenticatedUserRequest);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

return;

static IHost CreateHost() =>
    Host.CreateDefaultBuilder()
        .ConfigureServices((context, services) =>
        {
            services.AddMemoryCache();
        })
        .Build();