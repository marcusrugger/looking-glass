using Cairo;
using Gtk;
using System;

namespace LookingGlass.Adapter.GtkSharp {

using CreateCanvas = Func<Cairo.Context, Flatland.Canvas>;


public class Context : Adapter.Context
{
    readonly CreateCanvas fnCreateCanvas = (c) => Flatland.Core.Canvas.Create( Flatland.CairoGraphics.Context.Create(c) );

    public Context()
    {}

    public override Adapter.Window CreateWindow()
    {
        return new GtkSharp.Window(this, fnCreateCanvas);
    }
}

}
