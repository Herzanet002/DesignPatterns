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

var contextIdForValidRequest = Guid.NewGuid();

var validUserRequest = new UserRequest(DateTime.Now, true, contextIdForValidRequest);
var validCachedUserRequest = new UserRequest(DateTime.Now, true, contextIdForValidRequest);
var expiredUserRequest = new UserRequest(DateTime.Now.AddMinutes(-5), true, Guid.NewGuid());
var unauthenticatedUserRequest = new UserRequest(DateTime.Now, false, Guid.NewGuid());

await TryExecuteRequest(validUserRequest);
await TryExecuteRequest(validCachedUserRequest);
await TryExecuteRequest(expiredUserRequest);
await TryExecuteRequest(unauthenticatedUserRequest);

return;

async Task TryExecuteRequest(UserRequest request)
{
    try
    {
        await cacheDecorator.HandleRequest(request);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

static IHost CreateHost() =>
    Host.CreateDefaultBuilder()
        .ConfigureServices((context, services) => { services.AddMemoryCache(); })
        .Build();