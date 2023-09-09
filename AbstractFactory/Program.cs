using AbstractFactory.Factories.MacOS;
using AbstractFactory.Factories.Windows;
using AbstractFactory.Rendering;

var windowsFactory = new WindowsComponentsFactory();
var macOsFactory = new MacOSComponentsFactory();

var windowsButton = windowsFactory.CreateButton();
var windowsTextBox = windowsFactory.CreateTextBox();
var windowsLabel = windowsFactory.CreateLabel();

var macOsButton = macOsFactory.CreateButton();
var macOsTextBox = macOsFactory.CreateTextBox();
var macOsLabel = macOsFactory.CreateLabel();

var componentRenderer = new UiComponentRenderer();

componentRenderer.RenderComponent(windowsButton, new RenderParams(100, 100));
componentRenderer.RenderComponent(windowsTextBox, new RenderParams(100, 100));
componentRenderer.RenderComponent(windowsLabel, new RenderParams(100, 100));

Console.WriteLine(new string('-', 80));

componentRenderer.RenderComponent(macOsButton, new RenderParams(200, 200));
componentRenderer.RenderComponent(macOsTextBox, new RenderParams(200, 200));
componentRenderer.RenderComponent(macOsLabel, new RenderParams(200, 200));
