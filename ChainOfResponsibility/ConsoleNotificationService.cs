namespace ChainOfResponsibility;

public class ConsoleNotificationService : INotificationService
{
    public void Notify(string message) 
        => Console.WriteLine(message);
}