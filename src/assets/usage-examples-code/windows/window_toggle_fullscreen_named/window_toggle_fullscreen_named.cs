using System;
using SplashKitSDK;

class Program
{
    static void Main()
    {
        // Open a window initially
        Window myWindow = new Window("My Window", 800, 600);

        // Wait for a short time
        SplashKit.Delay(2000);

        // Toggle fullscreen mode
        SplashKit.WindowToggleFullscreen("My Window");

        // Keep the window open until manually closed
        while (!SplashKit.WindowCloseRequested("My Window"))
        {
            SplashKit.ProcessEvents();
            SplashKit.Delay(100);
        }
    }
}
