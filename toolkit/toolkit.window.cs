using System;

namespace LookingGlass.Toolkit {


// public class DrawEventArgs : EventArgs
// {
//     private Flatland.Canvas canvas;

//     public DrawEventArgs(Flatland.Canvas canvas)
//     {
//         this.canvas = canvas;
//     }

//     public Flatland.Canvas Canvas
//     { get { return canvas; } }
// }


public abstract class Window
{
    public delegate void DrawEventHandler(Flatland.Canvas canvas);
    public event DrawEventHandler DrawEvent;

    public delegate void CloseEventHandler();
    public event CloseEventHandler CloseEvent;

    readonly Adapter.Context adapterContext;
    readonly Adapter.Window  adapterWindow;

    public Window(Adapter.Context adapterContext)
    {
        this.adapterContext = adapterContext;
        this.adapterWindow  = adapterContext.CreateWindow();
        this.adapterWindow.DrawEvent  += this.OnDrawEvent;
        this.adapterWindow.CloseEvent += this.OnCloseEvent;
    }
    
    protected Adapter.Context Context
    { get { return adapterContext; } }

    public void Show()
    {
        adapterWindow.Show();
    }

    protected virtual void OnDrawEvent(Flatland.Canvas canvas)
    {
        if (DrawEvent != null) DrawEvent(canvas);
    }

    protected virtual void OnCloseEvent()
    {
        if (CloseEvent != null) CloseEvent();
    }
}

}
