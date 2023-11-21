namespace ChainOfResponsibility;

public class ChooseCategoryMessageHandler : AbstractMessageMessageHandler
{
    private readonly INotificationService _notificationService;

    public ChooseCategoryMessageHandler(INotificationService notificationService) 
        => _notificationService = notificationService;

    public override bool Handle(Message message)
    {
        switch (message.Content)
        {
            case "Выбор категории":
                _notificationService.Notify("Now you're in the category selection section");
                return true;
            default:
                return base.Handle(message);
        }
    }
}