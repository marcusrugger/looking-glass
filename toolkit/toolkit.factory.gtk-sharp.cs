using System;

namespace LookingGlass.Toolkit {


public class Factory
{
    public static LookingGlass.Adapter.Context CreateContext()
    {
        return new LookingGlass.Adapter.GtkSharp.Context();
    } 
}

}