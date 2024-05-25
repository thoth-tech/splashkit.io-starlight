using SplashKitSDK;
using System;

class Program
{
    static void Main()
    {
        const string windowName = "My Window";

        // Open a window
        Window myWindow = new Window(windowName, 800, 600);

        // Get the position of the window by name
        Point2D windowPosition = SplashKit.WindowPosition(windowName);

        // Print the window position
        Console.WriteLine($"Position of window '{windowName}': X={windowPosition.X}, Y={windowPosition.Y}");

        // Keep the window open until manually closed
        while (!myWindow.CloseRequested)
        {
            SplashKit.ProcessEvents();
            SplashKit.Delay(100);
        }
    }
}
