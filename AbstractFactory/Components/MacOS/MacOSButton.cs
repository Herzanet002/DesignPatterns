using AbstractFactory.Rendering;

namespace AbstractFactory.Components.MacOS;

public class MacOSButton : Button
{
    public override void RenderComponent(RenderParams renderParams)
    {
        Console.WriteLine(
            $"Button component for MacOS renders with params: " +
            $"{nameof(renderParams.Height)} : {renderParams.Height}, " +
            $"{nameof(renderParams.Width)} : {renderParams.Width}");
    }
}
