using System.Drawing;

namespace AbstractFactory.Components.MacOS;

public class MacOSTextBox : TextBox
{
    public MacOSTextBox(Point size) 
        => Size = size;
}