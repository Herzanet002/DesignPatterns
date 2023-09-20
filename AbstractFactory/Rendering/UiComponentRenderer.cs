using AbstractFactory.Components;

namespace AbstractFactory.Rendering;

public class UiComponentRenderer : IUiComponentRenderer
{
    public void RenderComponent(UiComponent uiComponent, RenderParams renderParams)
    {
        var componentName = uiComponent.GetType().Name;
        Console.WriteLine(
            $"{componentName} renders with params: " +
            $"{nameof(uiComponent.Size)} : {uiComponent.Size}. " +
            $"Width : {renderParams.Position.X}, " +
            $"Height : {renderParams.Position.Y}");
    }
}