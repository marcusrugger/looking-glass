using System;

namespace LookingGlass.Adapter {


public class Factory
{
    public static LookingGlass.Adapter.Context CreateContext()
    {
        return new LookingGlass.Adapter.GtkSharp.Context();
    } 
}

}