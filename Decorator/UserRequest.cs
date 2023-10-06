namespace Decorator;

public class UserRequest
{
    public Guid ContextId { get; set; }
    
    public DateTime RequestedAt { get; set; }

    public bool IsAuthenticated { get; set; }
    
    public bool IsCached { get; set; }

    public UserRequest(DateTime requestedAt, bool isAuthenticated, Guid contextId)
    {
        RequestedAt = requestedAt;
        IsAuthenticated = isAuthenticated;
        ContextId = contextId;
    }
}