using System.Drawing;

namespace AbstractFactory.Components.Windows;

public class WindowsTextBox : TextBox
{
    public WindowsTextBox(Point size) 
        => Size = size;
}