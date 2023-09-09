using AbstractFactory.Rendering;

namespace AbstractFactory.Components.Windows;

public class WindowsButton : Button
{
    public override void RenderComponent(RenderParams renderParams)
    {
        Console.WriteLine(
            $"Button component for Windows renders with params: " +
            $"{nameof(renderParams.Height)} : {renderParams.Height}, " +
            $"{nameof(renderParams.Width)} : {renderParams.Width}");
    }
}