using AbstractFactory.Components;
using AbstractFactory.Components.Windows;

namespace AbstractFactory.Factories.Windows;

public class WindowsComponentsFactory : IUiComponentsFactory
{
    public Button CreateButton()
        => new WindowsButton();

    public TextBox CreateTextBox()
        => new WindowsTextBox();

    public Label CreateLabel()
        => new WindowsLabel();
}