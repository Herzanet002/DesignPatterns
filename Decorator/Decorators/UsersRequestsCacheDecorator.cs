using Decorator.Handlers;
using Microsoft.Extensions.Caching.Memory;

namespace Decorator.Decorators;

public class UsersRequestsCacheDecorator : AbstractDecorator
{
    private readonly IMemoryCache _memoryCache;
    
    public UsersRequestsCacheDecorator(IUserRequestHandler userRequestHandler, IMemoryCache memoryCache) 
        : base(userRequestHandler)
        => _memoryCache = memoryCache;

    public override Task HandleRequest(UserRequest request)
    {
        var cacheKey = nameof(HandleRequest) + request.ContextId;
        if (_memoryCache.TryGetValue(cacheKey, out UserRequest? userRequest))
        {
            if (userRequest != null)
            {
                userRequest.IsCached = true;
                return base.HandleRequest(userRequest);
            }
        }

        _memoryCache.Set(cacheKey, request);
        return base.HandleRequest(request);
    }
}