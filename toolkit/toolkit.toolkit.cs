using System;

namespace LookingGlass.Toolkit {


public class Toolkit
{
    readonly Adapter.Context context;

    public Toolkit(Adapter.Context context)
    {
        this.context = context;
    }

    public ApplicationWindow CreateApplicationWindow()
    {
        return new Toolkit.ApplicationWindow( context.CreateWindow() );
    }
}

}