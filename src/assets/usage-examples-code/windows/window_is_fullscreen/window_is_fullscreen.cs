using SplashKitSDK;
using System;

class Program
{
    static void Main()
    {
        const string windowName = "My Window";

        // Open a window
        Window myWindow = new Window(windowName, 800, 600);

        // Check if the window is fullscreen
        bool isFullscreen = SplashKit.WindowIsFullscreen(myWindow);

        // Print the result
        Console.WriteLine($"Is window '{windowName}' fullscreen? {isFullscreen}");

        // Keep the window open until manually closed
        while (!myWindow.CloseRequested)
        {
            SplashKit.ProcessEvents();
            SplashKit.Delay(100);
        }
    }
}
