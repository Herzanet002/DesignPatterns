using System.Drawing;

namespace AbstractFactory.Components.Windows;

public class WindowsLabel : Label
{
    public WindowsLabel(Point size) 
        => Size = size;
}