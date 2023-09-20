using Decorator.Handlers;

namespace Decorator.Decorators;

public abstract class Decorator : IUserRequestHandler
{
    private readonly IUserRequestHandler _userRequestHandler;

    protected Decorator(IUserRequestHandler userRequestHandler)
        => _userRequestHandler = userRequestHandler;
    
    public virtual async Task HandleRequest(UserRequest request)
        => await _userRequestHandler.HandleRequest(request);
}