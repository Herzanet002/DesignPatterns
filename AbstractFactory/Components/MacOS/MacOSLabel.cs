using AbstractFactory.Rendering;

namespace AbstractFactory.Components.MacOS;

public class MacOSLabel : Label
{
    public override void RenderComponent(RenderParams renderParams)
    {
        Console.WriteLine(
            $"Label component for MacOS renders with params: " +
            $"{nameof(renderParams.Height)} : {renderParams.Height}, " +
            $"{nameof(renderParams.Width)} : {renderParams.Width}");
    }
}