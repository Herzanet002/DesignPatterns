namespace Decorator;

public class UserRequest
{
    public int ContextId { get; set; }
    
    public DateTime RequestDate { get; set; }

    public bool IsAuthenticated { get; set; }
    
    public bool IsCached { get; set; }

    public UserRequest(DateTime requestDate, bool isAuthenticated, int contextId)
    {
        RequestDate = requestDate;
        IsAuthenticated = isAuthenticated;
        ContextId = contextId;
    }

    public UserRequest(int contextId)
    {
        ContextId = contextId;
    }
}