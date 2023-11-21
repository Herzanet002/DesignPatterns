namespace Mediator;

public interface IMediator
{
    void Notify(string Message, Colleague colleague);
}