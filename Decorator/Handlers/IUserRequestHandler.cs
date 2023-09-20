namespace Decorator.Handlers;

public interface IUserRequestHandler
{
    Task HandleRequest(UserRequest request);
}