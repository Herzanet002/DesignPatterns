using System.Drawing;

namespace AbstractFactory.Components.MacOS;

public class MacOSLabel : Label
{
    public MacOSLabel(Point size) 
        => Size = size;
}