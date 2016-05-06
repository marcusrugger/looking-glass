using System;

namespace LookingGlass.Toolkit {


public class Toolkit
{
    readonly Adapter.Context context;

    public static Toolkit Create()
    {
        var context = LookingGlass.Toolkit.Factory.CreateContext();
        return new LookingGlass.Toolkit.Toolkit(context);
    }

    private Toolkit(Adapter.Context context)
    {
        this.context = context;
    }

    public void Run()
    {
        context.Run();
    }

    public ApplicationWindow CreateApplicationWindow()
    {
        return new LookingGlass.Toolkit.ApplicationWindow( context.CreateWindow() );
    }
}

}
