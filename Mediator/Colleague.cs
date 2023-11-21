namespace Mediator;

public abstract class Colleague
{
    public IMediator Mediator { get; set; }

    public Colleague(IMediator mediator)
    {
        Mediator = mediator;
    }
}