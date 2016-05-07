using System;
using LookingGlass;

namespace LookingGlass.Toolkit {


public class Toolkit
{
    readonly Adapter.Context context;

    public static Toolkit Create()
    {
        var context = Factory.CreateContext();
        return new Toolkit(context);
    }

    private Toolkit(Adapter.Context context)
    {
        this.context = context;
    }

    public void Run()
    {
        context.Run();
    }

    public void Quit()
    {
        context.Quit();
    }

    public ApplicationWindow CreateApplicationWindow()
    {
        return new ApplicationWindow(context);
    }
}

}
