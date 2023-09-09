using AbstractFactory.Rendering;

namespace AbstractFactory.Components;

public abstract class UiComponent
{
    public abstract void RenderComponent(RenderParams renderParams);
}