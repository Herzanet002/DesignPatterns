using System.Drawing;
using AbstractFactory.Factories.MacOS;
using AbstractFactory.Factories.Windows;
using AbstractFactory.Rendering;

var windowsFactory = new WindowsComponentsFactory();
var macOsFactory = new MacOSComponentsFactory();

var componentSize = new Point(100, 100);

var windowsButton = windowsFactory.CreateButton(componentSize);
var windowsTextBox = windowsFactory.CreateTextBox(componentSize);
var windowsLabel = windowsFactory.CreateLabel(componentSize);

var macOsButton = macOsFactory.CreateButton(componentSize);
var macOsTextBox = macOsFactory.CreateTextBox(componentSize);
var macOsLabel = macOsFactory.CreateLabel(componentSize);

var componentRenderer = new UiComponentRenderer();
var componentPosition = new Point(100, 100);

componentRenderer.RenderComponent(windowsButton, new RenderParams(componentPosition));
componentRenderer.RenderComponent(windowsTextBox, new RenderParams(componentPosition));
componentRenderer.RenderComponent(windowsLabel, new RenderParams(componentPosition));

Console.WriteLine(new string('-', 80));

componentRenderer.RenderComponent(macOsButton, new RenderParams(componentPosition));
componentRenderer.RenderComponent(macOsTextBox, new RenderParams(componentPosition));
componentRenderer.RenderComponent(macOsLabel, new RenderParams(componentPosition));
