using System;

namespace LookingGlass.Adapter {


public abstract class Window
{
    public delegate void DrawEventHandler(Flatland.Canvas canvas);
    public event DrawEventHandler DrawEvent;

    public delegate void CloseEventHandler();
    public event CloseEventHandler CloseEvent;

    readonly Adapter.Context context;

    protected Window(Adapter.Context context)
    {
        this.context = context;
    }
    
    public abstract void Show();

    protected void OnDrawEvent(Flatland.Canvas canvas)
    {
        if (DrawEvent != null) DrawEvent(canvas);
    }

    protected void OnCloseEvent()
    {
        if (CloseEvent != null) CloseEvent();
    }
}

}
