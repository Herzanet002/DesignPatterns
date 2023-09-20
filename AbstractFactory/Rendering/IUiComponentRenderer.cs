using AbstractFactory.Components;

namespace AbstractFactory.Rendering;

public interface IUiComponentRenderer
{
    void RenderComponent(UiComponent uiComponent, RenderParams renderParams);
}