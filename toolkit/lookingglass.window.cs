using System;
using LookingGlass.Toolkit;


public class AppWindow
{
    readonly Toolkit toolkit;
    readonly Window window;

    public AppWindow(Toolkit toolkit)
    {
        this.toolkit = toolkit;
        this.window  = toolkit.CreateApplicationWindow();
        this.window.OnDraw += DrawEvent;
        this.window.Show();
    }

    private void DrawOn(Flatland.Canvas canvas)
    {
        Flatland.Wireframe graphics = canvas.Wireframe();
        graphics.Circle(200.0, 200.0, 100.0);
        graphics.Line(200.0, 100.0, 200.0, 300.0);
        graphics.Line(100.0, 200.0, 300.0, 200.0);
    }

    private void DrawEvent(Object obj, DrawEventArgs args)
    {
        DrawOn(args.Canvas);
    }
}
