namespace Decorator.Handlers;

public class UsersRequestUserRequestHandler : IUserRequestHandler
{
    public async Task HandleRequest(UserRequest request)
    {
        var cachedResult = request.IsCached ? "cached" : "not cached";
        Console.WriteLine(
            $"[{request.RequestedAt}]: Got {cachedResult} request {request.ContextId}");
        await Task.CompletedTask;
    }
}