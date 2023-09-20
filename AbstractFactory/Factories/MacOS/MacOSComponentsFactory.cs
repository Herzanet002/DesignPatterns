using System.Drawing;
using AbstractFactory.Components;
using AbstractFactory.Components.MacOS;

namespace AbstractFactory.Factories.MacOS;

public class MacOSComponentsFactory : IUiComponentsFactory
{
    public Button CreateButton(Point size)
        => new MacOSButton(size);

    public TextBox CreateTextBox(Point size)
        => new MacOSTextBox(size);

    public Label CreateLabel(Point size)
        => new MacOSLabel(size);
}