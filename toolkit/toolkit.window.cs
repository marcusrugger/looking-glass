using System;

namespace LookingGlass.Toolkit {


public abstract class Window
{
    readonly Adapter.Window adapterWindow;

    public Window(Adapter.Window adapterWindow)
    {
        this.adapterWindow = adapterWindow;

        this.adapterWindow.OnDraw += this.DrawEvent;
    }

    public abstract void DrawOn(Flatland.Canvas canvas);

    private void DrawEvent(Object obj, Adapter.DrawEventArgs args)
    {
        DrawOn(args.Canvas);
    }
}

}
