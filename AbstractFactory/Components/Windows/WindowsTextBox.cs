using AbstractFactory.Rendering;

namespace AbstractFactory.Components.Windows;

public class WindowsTextBox : TextBox
{
    public override void RenderComponent(RenderParams renderParams)
    {
        Console.WriteLine(
            $"TextBox component for Windows renders with params: " +
            $"{nameof(renderParams.Height)} : {renderParams.Height}, " +
            $"{nameof(renderParams.Width)} : {renderParams.Width}");
    }
}