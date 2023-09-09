using AbstractFactory.Rendering;

namespace AbstractFactory.Components.MacOS;

public class MacOSTextBox : TextBox
{
    public override void RenderComponent(RenderParams renderParams)
    {
        Console.WriteLine(
            $"TextBox component for MacOS renders with params: " +
            $"{nameof(renderParams.Height)} : {renderParams.Height}, " +
            $"{nameof(renderParams.Width)} : {renderParams.Width}");
    }
}