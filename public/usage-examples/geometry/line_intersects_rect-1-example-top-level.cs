using System;
using SplashKitSDK;

public class LineWidthExample
{
    private Window _window;

    public LineWidthExample()
    {
       // Create and open a new window
        _window = SplashKit.OpenWindow("Line Width Example", 800, 600);
    }

    public void Draw()
    {
        // Set line width to 10 and draw first rectangle
        SplashKit.OptionLineWidth(10);
        // Draws a black rectangle with the current line width at position (100, 100).
        SplashKit.DrawRectangle(Color.Black, 100, 100, 200, 150);

        // Set line width to 5 and draw second rectangle
        SplashKit.OptionLineWidth(5);
        // Draws a red rectangle with the current line width at position (400, 100).
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
