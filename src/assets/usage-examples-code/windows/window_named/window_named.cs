using SplashKitSDK;
using System;

public class Program
{
    public static void Main()
    {
        string windowName = "My Window";

        // Open a window
        Window myWindow = new Window(windowName, 800, 600);

        // Retrieve the window using its name
        Window retrievedWindow = SplashKit.WindowNamed(windowName);

        // Check if the retrieved window is the same as the created one
        bool isSameWindow = myWindow.Equals(retrievedWindow);

        // Print the result
        Console.WriteLine($"Is the retrieved window the same as the created one? {isSameWindow}");

        // Keep the window open until manually closed
        while (!myWindow.CloseRequested)
        {
            SplashKit.ProcessEvents();
            SplashKit.Delay(100);
        }
    }
}
