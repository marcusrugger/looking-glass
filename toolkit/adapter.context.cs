using System;

namespace LookingGlass.Adapter {


public abstract class Context
{
    protected Context()
    {}

    public abstract Adapter.Window CreateWindow();
}

}
