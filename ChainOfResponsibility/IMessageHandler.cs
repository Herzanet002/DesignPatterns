namespace ChainOfResponsibility;

public interface IMessageHandler
{
    IMessageHandler SetNext(IMessageHandler messageHandler);

    bool Handle(Message message);
}