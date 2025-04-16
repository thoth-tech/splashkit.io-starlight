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
        // Set line width to 10 and draw first rectangle
        SplashKit.OptionLineWidth(10);
        SplashKit.DrawRectangle(Color.Black, 100, 100, 200, 150);

        // Set line width to 5 and draw second rectangle
        SplashKit.OptionLineWidth(5);
        SplashKit.DrawRectangle(Color.Red, 400, 100, 200, 150);

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