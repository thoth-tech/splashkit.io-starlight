using SplashKitSDK;

class Program
{
    static void Main()
    {
        // Open a window
        Window myWindow = new Window("My Window", 800, 600);

        // Get the height of the window
        int height = SplashKit.WindowHeight(myWindow);

        // Print the height to the console
        System.Console.WriteLine($"Height of window 'My Window': {height}");

        // Keep the window open until manually closed
        while (!myWindow.CloseRequested)
        {
            SplashKit.ProcessEvents();
            SplashKit.Delay(100);
        }
    }
}
