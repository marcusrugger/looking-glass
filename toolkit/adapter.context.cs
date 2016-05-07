using System;

namespace LookingGlass.Adapter {


public abstract class Context
{
    public static Context Create()
    {
        return LookingGlass.Toolkit.Factory.CreateContext();
    }

    protected Context()
    {}

    public abstract void Run();
    public abstract void Quit();
    public abstract Adapter.Window CreateWindow();
}

}
