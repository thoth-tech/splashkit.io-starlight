using SplashKitSDK;
using System;

class Program
{
    static void Main()
    {
        // Open a window
        Window myWindow = new Window("My Window", 800, 600);

        // Get the position of the window
        Point2D windowPosition = SplashKit.WindowPosition(myWindow);

        // Print the window position
        Console.WriteLine($"Window position: X={windowPosition.X}, Y={windowPosition.Y}");

        // Keep the window open until manually closed
        while (!myWindow.CloseRequested)
        {
            SplashKit.ProcessEvents();
            SplashKit.Delay(100);
        }
    }
}
