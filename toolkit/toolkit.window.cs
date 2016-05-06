using System;

namespace LookingGlass.Toolkit {


public abstract class Window
{
    readonly Adapter.Window adapterWindow;

    public Window(Adapter.Window adapterWindow)
    {
        this.adapterWindow = adapterWindow;
    }

    public abstract void DrawOn(Flatland.Canvas canvas);
}

}
