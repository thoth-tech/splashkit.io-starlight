using System;
using SplashKitSDK;

class Program
{
    static void Main()
    {
        // Open a window initially
        Window myWindow = new Window("My Window", 800, 600);

        // Get and print the window width
        Console.WriteLine($"Window width: {SplashKit.WindowWidth(myWindow)}");

        // Keep the window open until manually closed
        while (!SplashKit.WindowCloseRequested(myWindow))
        {
            SplashKit.ProcessEvents();
        }
    }
}
