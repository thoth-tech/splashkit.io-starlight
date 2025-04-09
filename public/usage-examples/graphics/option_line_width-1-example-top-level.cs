using System;
using SplashKitSDK;

public class LineWidthExample
{
    private Window _window;

    public LineWidthExample()
    {
        _window = SplashKit.OpenWindow("Line Width Example", 800, 600);
    }

    public void Draw()
    {
        // Set line width to 10 and draw the first line
        var opt1 = SplashKit.OptionLineWidth(10);
        SplashKit.DrawLine(Color.Black, 100, 100, 200, 200, opt1);  // Draw a line instead of a rectangle

        // Set line width to 5 and draw the second line
        var opt2 = SplashKit.OptionLineWidth(5);
        SplashKit.DrawLine(Color.Red, 400, 100, 600, 250, opt2);  // Draw a line instead of a rectangle

        SplashKit.RefreshScreen();
    }

    public void Run()
    {
        Draw();

        // Keep the window open until the user closes it
        while (!_window.CloseRequested)
        {
            SplashKit.ProcessEvents();
        }
    }
}

public class Program
{
    public static void Main()
    {
        LineWidthExample example = new LineWidthExample();
        example.Run();
    }
}
