using System;

namespace LookingGlass.Toolkit {


public class ApplicationWindow : LookingGlass.Toolkit.Window
{
    public ApplicationWindow(Adapter.Window adapterWindow) : base(adapterWindow)
    {}

    public override void DrawOn(Flatland.Canvas canvas)
    {
        canvas.Wireframe().Circle(200.0, 200.0, 100.0);
    }
}

}
