using System;
using SplashKitSDK;

class Program
{
    static void Main()
    {
        // Open a window with a border initially
        Window myWindow = new Window("My Window", 800, 600);

        // Wait for a short time
        SplashKit.Delay(2000);

        // Toggle the border off
        SplashKit.WindowToggleBorder(myWindow);

        // Wait for a short time
        SplashKit.Delay(2000);

        // Toggle the border back on
        SplashKit.WindowToggleBorder(myWindow);

        // Keep the window open until manually closed
        while (!SplashKit.WindowCloseRequested(myWindow))
        {
            SplashKit.ProcessEvents();
            SplashKit.Delay(100);
        }
    }
}
