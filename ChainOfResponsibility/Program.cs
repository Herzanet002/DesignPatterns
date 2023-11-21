using ChainOfResponsibility;

var notificationService = new ConsoleNotificationService();
var defaultHandler = new DefaultMessageMessageHandler(notificationService);
var chooseHandler = new ChooseCategoryMessageHandler(notificationService);
defaultHandler.SetNext(chooseHandler);
while (true)
{
    var command = Console.ReadLine();
    if (command == "exit")
    {
        break;
    }
    defaultHandler.Handle(new Message { Content = command });
}