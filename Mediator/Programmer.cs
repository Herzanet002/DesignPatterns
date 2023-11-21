namespace Mediator;

public class Programmer : Colleague
{
    
    public void WriteCode(string tz)
    {
        Console.WriteLine("Программист пишет код...");
        Thread.Sleep(2000);
        Console.WriteLine("Программист написал код: {0}", tz);
        Mediator.Notify("Code: ...", this);
    }

    public Programmer(IMediator mediator) : base(mediator)
    {
    }
}