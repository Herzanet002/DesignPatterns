using AbstractFactory.Components;

namespace AbstractFactory.Factories;

public interface IUiComponentsFactory
{
    Button CreateButton();

    TextBox CreateTextBox();

    Label CreateLabel();
}
