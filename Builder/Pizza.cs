namespace Builder;

public class Pizza
{
    public string Dough { get; set; } = null!;

    public string? Sauce { get; set; }

    public IEnumerable<string> Toppings { get; set; } = null!;

    public override string ToString()
    {
        return $"Dough: {Dough}, Sauce: {Sauce}, Toppings: {string.Join(',', Toppings)}";
    }
}