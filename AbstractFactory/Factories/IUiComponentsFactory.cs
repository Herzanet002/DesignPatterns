using System.Drawing;
using AbstractFactory.Components;

namespace AbstractFactory.Factories;

public interface IUiComponentsFactory
{
    Button CreateButton(Point size);

    TextBox CreateTextBox(Point size);

    Label CreateLabel(Point size);
}
