using Cairo;
using Gtk;
using System;

namespace LookingGlass.Adapter.GtkSharp {


public class Context : Adapter.Context
{
    protected Context()
    {}

    public override Adapter.Window CreateWindow()
    {
        Func<Cairo.Context, Flatland.Canvas> fn = (c) => Flatland.Core.Canvas.Create( Flatland.CairoGraphics.Context.Create(c) );
        return new GtkSharp.Window(this, fn);
    }
}

}
