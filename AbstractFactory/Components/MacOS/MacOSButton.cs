using System.Drawing;

namespace AbstractFactory.Components.MacOS;

public class MacOSButton : Button
{
    public MacOSButton(Point size)
        => Size = size;
}