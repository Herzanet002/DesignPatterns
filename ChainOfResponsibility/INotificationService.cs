namespace ChainOfResponsibility;

public interface INotificationService
{
    void Notify(string message);
}