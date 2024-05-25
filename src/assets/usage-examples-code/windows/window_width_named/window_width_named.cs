using System;
using SplashKitSDK;

class Program
{
    static void Main(string[] args)
    {
        SplashKit.OpenWindow("My Window", 800, 600);
        Console.WriteLine("Window width: " + SplashKit.ScreenWidth());
        System.Threading.Thread.Sleep(2000);  // Wait for 2 seconds before closing the window
        SplashKit.CloseAllWindows();
    }
}
