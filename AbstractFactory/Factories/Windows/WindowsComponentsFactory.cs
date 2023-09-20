using System.Drawing;
using AbstractFactory.Components;
using AbstractFactory.Components.Windows;

namespace AbstractFactory.Factories.Windows;

public class WindowsComponentsFactory : IUiComponentsFactory
{
    public Button CreateButton(Point size)
        => new WindowsButton(size);

    public TextBox CreateTextBox(Point size)
        => new WindowsTextBox(size);

    public Label CreateLabel(Point size)
        => new WindowsLabel(size);
}