using Builder;

var builder = new PizzaMargaritaBuilder();
var director = new PizzaDirector(builder);
director.Build();
Console.WriteLine(builder.GetResult());