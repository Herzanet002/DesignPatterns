namespace ChainOfResponsibility;

public abstract class AbstractMessageMessageHandler : IMessageHandler
{
    private IMessageHandler? _nextHandler;

    public IMessageHandler SetNext(IMessageHandler messageHandler)
    {
        _nextHandler = messageHandler;
        return messageHandler;
    }

    public virtual bool Handle(Message message)
        => _nextHandler != null && _nextHandler.Handle(message);
}