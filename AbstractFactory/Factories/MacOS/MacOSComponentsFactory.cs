using AbstractFactory.Components;
using AbstractFactory.Components.MacOS;

namespace AbstractFactory.Factories.MacOS;

public class MacOSComponentsFactory : IUiComponentsFactory
{
    public Button CreateButton()
        => new MacOSButton();

    public TextBox CreateTextBox()
        => new MacOSTextBox();

    public Label CreateLabel()
        => new MacOSLabel();
}