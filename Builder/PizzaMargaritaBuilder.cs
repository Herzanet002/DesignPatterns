namespace Builder;

public class PizzaMargaritaBuilder : IBuilder
{
    private Pizza _pizza = new();

    public IBuilder PrepareDough()
    {
        _pizza.Dough = "Thin";
        return this;
    }

    public IBuilder AddSauce()
    {
        _pizza.Sauce = "Ketchup";
        return this;
    }

    public IBuilder AddToppings()
    {
        _pizza.Toppings = new List<string>()
        {
            "Cheeze"
        };
        return this;
    }

    public IBuilder Roast()
    {
        Console.WriteLine("Bake pizza at temp 180 degree ...");
        return this;
    }

    public Pizza GetResult() => _pizza;
}