using Decorator.Handlers;

namespace Decorator.Decorators;

public abstract class AbstractDecorator : IUserRequestHandler
{
    private readonly IUserRequestHandler _userRequestHandler;

    protected AbstractDecorator(IUserRequestHandler userRequestHandler)
        => _userRequestHandler = userRequestHandler;
    
    public virtual async Task HandleRequest(UserRequest request)
        => await _userRequestHandler.HandleRequest(request);
}