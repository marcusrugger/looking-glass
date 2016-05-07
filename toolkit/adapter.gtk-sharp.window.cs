using Cairo;
using Gtk;
using System;

namespace LookingGlass.Adapter.GtkSharp {

using CreateCanvas = System.Func<Cairo.Context, Flatland.Canvas>;


public class Window : Adapter.Window
{
    readonly GtkSharpWindow child;

    public Window(Adapter.Context context, CreateCanvas fnCreateCanvas) : base(context)
    {
        this.child = new GtkSharpWindow(this, fnCreateCanvas);
    }

    public override void Show()
    {
        child.ShowAll();
    }

    class GtkSharpWindow : Gtk.Window
    {
        readonly GtkSharp.Window parent;
        readonly CreateCanvas fnCreateCanvas;

        public GtkSharpWindow(GtkSharp.Window parent, CreateCanvas fnCreateCanvas) : base("LookingGlass - GtkSharp")
        {
            this.parent = parent;
            this.fnCreateCanvas = fnCreateCanvas;
            this.DeleteEvent += OnDeleteEvent;
            SetDefaultSize(1000, 1000);
        }

        protected override bool OnDrawn(Cairo.Context context)
        {
            bool result = base.OnDrawn(context);
            parent.OnDrawEvent( fnCreateCanvas(context) );
            return result;
        }

        protected void OnDeleteEvent(Object obj, DeleteEventArgs args)
        {
            parent.OnCloseEvent();
        }
    }
}

}
