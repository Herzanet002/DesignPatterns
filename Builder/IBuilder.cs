namespace Builder;

public interface IBuilder
{
    IBuilder PrepareDough();

    IBuilder AddSauce();

    IBuilder AddToppings();

    IBuilder Roast();
}