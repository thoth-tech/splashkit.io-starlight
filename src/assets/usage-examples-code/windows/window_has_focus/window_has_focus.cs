using SplashKitSDK;

class Program
{
    static void Main()
    {
        Window myWindow = new Window("My Window", 800, 600);
        
        // Check if the window has focus
        bool hasFocus = SplashKit.WindowHasFocus(myWindow);

        // Print the result
        if (hasFocus)
        {
            System.Console.WriteLine("Window 'My Window' has focus.");
        }
        else
        {
            System.Console.WriteLine("Window 'My Window' does not have focus.");
        }

        // Keep the window open until manually closed
        while (!myWindow.CloseRequested)
        {
            SplashKit.ProcessEvents();
            SplashKit.Delay(100);
        }
    }
}
