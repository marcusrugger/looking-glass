using System;

namespace LookingGlass.Toolkit {


public class ApplicationWindow : LookingGlass.Toolkit.Window
{
    public ApplicationWindow(Adapter.Context adapterContext) : base(adapterContext)
    {}

    protected override void OnCloseEvent()
    {
        Context.Quit();
    }
}

}
