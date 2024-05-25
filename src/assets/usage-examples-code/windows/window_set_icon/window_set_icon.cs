using SplashKitSDK;
using System;

class Program
{
    static void Main()
    {
        // Load an existing bitmap as the icon
        Bitmap iconBitmap = new Bitmap("existing_bitmap", "path/to/your/bitmap.png");

        // Open a window
        Window myWindow = new Window("My Window", 800, 600);

        // Set the window icon
        SplashKit.WindowSetIcon(myWindow, iconBitmap);

        // Keep the window open until manually closed
        while (!myWindow.CloseRequested)
        {
            SplashKit.ProcessEvents();
            SplashKit.Delay(100);
        }
    }
}
