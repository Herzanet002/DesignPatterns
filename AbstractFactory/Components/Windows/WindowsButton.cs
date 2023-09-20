using System.Drawing;

namespace AbstractFactory.Components.Windows;

public class WindowsButton : Button
{
    public WindowsButton(Point size) 
        => Size = size;
}