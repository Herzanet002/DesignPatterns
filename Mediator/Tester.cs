namespace Mediator;

public class Tester : Colleague
{
    public void Test(string code)
    {
        Console.WriteLine("Отчет по тестированию: {0}", code);
    }

    public Tester(IMediator mediator) : base(mediator)
    {
    }
}