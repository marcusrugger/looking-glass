using Gtk;
using System;


public class TheLookingGlass
{
    static public void Main ()
    {
        Application.Init();

        var context = new LookingGlass.Adapter.GtkSharp.Context();
        var toolkit = new LookingGlass.Toolkit.Toolkit(context);
        var window  = toolkit.CreateApplicationWindow();

        Application.Run();
    }
}
