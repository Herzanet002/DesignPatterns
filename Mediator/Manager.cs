namespace Mediator;

public class Manager : Colleague, IMediator
{
    public Programmer Programmer { get; set; }
    public Tester Tester { get; set; }

    public Manager() : base(null)
    {
    }
    
    public void Notify(string message, Colleague colleague)
    {
        if (colleague == Programmer)
        {
            Console.WriteLine($"Пришло сообщение от программиста: {message}");
            Tester.Test(message);
        }
        else if (colleague == Tester)
        {
            Console.WriteLine($"Пришло сообщение от тестировщика: {message}");
        }
    }

    public void StartWork(string tz)
    {
        Programmer.WriteCode(tz);
    }
}