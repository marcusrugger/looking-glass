using System;

namespace LookingGlass.Adapter {


public class DrawEventArgs : EventArgs
{
    private Flatland.Canvas canvas;

    public DrawEventArgs(Flatland.Canvas canvas)
    {
        this.canvas = canvas;
    }

    public Flatland.Canvas Canvas
    { get { return canvas; } }
}


public abstract class Window
{
    public event EventHandler<DrawEventArgs> OnDraw;

    readonly Adapter.Context context;

    protected Window(Adapter.Context context)
    {
        this.context = context;
    }

    protected void RaiseDrawEvent(Flatland.Canvas canvas)
    {
        OnDraw(this, new DrawEventArgs(canvas));
    }
}

}
