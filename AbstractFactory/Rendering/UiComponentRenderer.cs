using AbstractFactory.Components;

namespace AbstractFactory.Rendering;

public class UiComponentRenderer : IUiComponentRenderer
{
    public void RenderComponent(UiComponent uiComponent, RenderParams renderParams)
        => uiComponent.RenderComponent(renderParams);
}