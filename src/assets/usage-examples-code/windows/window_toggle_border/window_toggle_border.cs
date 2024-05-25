using SplashKitSDK;
using System;

class Program
{
    static void Main()
    {
        // Open a window with a border initially
        Window myWindow = new Window("My Window", 800, 600);

        // Draw something to see the border toggle effect
        Bitmap background = new Bitmap("background", 800, 600);
        myWindow.DrawBitmap(background, 0, 0);

        // Wait for a short time
        SplashKit.Delay(2000);

        // Toggle the border off
        SplashKit.WindowToggleBorder(myWindow);

        // Wait for a short time
        SplashKit.Delay(2000);

        // Toggle the border back on
        SplashKit.WindowToggleBorder(myWindow);

        // Keep the window open until manually closed
        while (!myWindow.CloseRequested)
        {
            SplashKit.ProcessEvents();
            SplashKit.Delay(100);
        }
    }
}
