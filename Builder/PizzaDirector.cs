namespace Builder;

public class PizzaDirector
{
    private readonly IBuilder _builder;

    public PizzaDirector(IBuilder builder)
        => _builder = builder;

    public void Build()
        => _builder
            .PrepareDough()
            .AddSauce()
            .AddToppings()
            .Roast();
}