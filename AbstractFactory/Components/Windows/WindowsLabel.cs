using AbstractFactory.Rendering;

namespace AbstractFactory.Components.Windows;

public class WindowsLabel : Label
{
    public override void RenderComponent(RenderParams renderParams)
    {
        Console.WriteLine(
            $"Label component for Windows renders with params: " +
            $"{nameof(renderParams.Height)} : {renderParams.Height}, " +
            $"{nameof(renderParams.Width)} : {renderParams.Width}");
    }
}