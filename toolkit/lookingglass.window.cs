using Flatland;
using LookingGlass.Toolkit;
using System;


public class AppWindow
{
    readonly Toolkit toolkit;
    readonly Window window;

    public AppWindow(Toolkit toolkit)
    {
        this.toolkit = toolkit;
        this.window  = toolkit.CreateApplicationWindow();
        this.window.DrawEvent  += DrawOn;
        this.window.Show();
    }

    private void DrawOn(Canvas canvas)
    {
        Wireframe graphics = canvas.Wireframe();
        graphics . SetLineColor(Colors.Red)   . Circle(200.0, 200.0, 100.0);
        graphics . SetLineColor(Colors.Green) . Line(200.0, 100.0, 200.0, 300.0);
        graphics . SetLineColor(Colors.Blue)  . Line(100.0, 200.0, 300.0, 200.0);
    }
}
