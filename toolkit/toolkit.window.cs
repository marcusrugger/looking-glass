using System;

namespace LookingGlass.Toolkit {


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

    readonly Adapter.Window adapterWindow;

    public Window(Adapter.Window adapterWindow)
    {
        this.adapterWindow = adapterWindow;

        this.adapterWindow.OnDraw += this.DrawEvent;
    }

    public void Show()
    {
        adapterWindow.Show();
    }

    private void DrawEvent(Object obj, Adapter.DrawEventArgs args)
    {
        if (OnDraw != null) OnDraw(this, new DrawEventArgs(args.Canvas));
    }
}

}
