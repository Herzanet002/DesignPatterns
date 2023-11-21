namespace ChainOfResponsibility;

public class DefaultMessageMessageHandler : AbstractMessageMessageHandler
{
    private readonly INotificationService _notificationService;

    public DefaultMessageMessageHandler(INotificationService notificationService)
        => _notificationService = notificationService;

    public override bool Handle(Message message)
    {
        switch (message.Content)
        {
            case "/start" or "start" or "Привет" or "привет" or "hello" or "Hello":
                _notificationService.Notify("Привет! 😊");
                return true;

            case not null when message.Content.ToLower().Contains("главное меню"):
                _notificationService.Notify("Переход в главное меню 🏠");
                return true;

            case not null when message.Content.ToLower() == "читать новости"
                               || message.Content.ToLower() == "новости"
                               || message.Content.ToLower() == "читать":
                _notificationService.Notify("Переход в раздел новостей 📰");
                return true;
                return true;

            default:
                return base.Handle(message);
        }
    }
}