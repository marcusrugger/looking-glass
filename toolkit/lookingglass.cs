using System;
using LookingGlass.Toolkit;


public class TheLookingGlass
{
    static public void Main ()
    {
        var toolkit = Toolkit.Create();
        var window  = new AppWindow(toolkit);
        toolkit.Run();
    }
}
