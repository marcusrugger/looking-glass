using Cairo;
using Gtk;
using System;

namespace LookingGlass.Adapter.GtkSharp {

using CreateCanvas = Func<Cairo.Context, Flatland.Canvas>;


public class Window : Adapter.Window
{
    readonly GtkSharpWindow child;

    public Window(Adapter.Context context, CreateCanvas fnCreateCanvas) : base(context)
    {
        this.child = new GtkSharpWindow(this, fnCreateCanvas);
    }

    class GtkSharpWindow : Gtk.Window
    {
        readonly GtkSharp.Window parent;
        readonly CreateCanvas fnCreateCanvas;

        public GtkSharpWindow(GtkSharp.Window parent, CreateCanvas fnCreateCanvas) : base("GtkSharp Test App")
        {
            this.parent = parent;
            this.fnCreateCanvas = fnCreateCanvas;
            SetDefaultSize(1000, 1000);
            ShowAll();
        }

        protected override bool OnDrawn(Cairo.Context context)
        {
            bool result = base.OnDrawn(context);
            parent.RaiseDrawEvent( fnCreateCanvas(context) );
            return result;
        }
    }
}

}
