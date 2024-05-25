using SplashKitSDK;

class Program
{
    static void Main()
    {
        const string windowName = "My Window";

        // Get the window object by name
        Window myWindow = SplashKit.WindowNamed(windowName);

        if (myWindow != null)
        {
            // Get the height of the window
            int height = myWindow.Height;

            // Print the height to the console
            System.Console.WriteLine($"Height of window '{windowName}': {height}");

            // Open a window with the specified height
            myWindow = new Window("My Window", 800, height);

            // Keep the window open until manually closed
            while (!myWindow.CloseRequested)
            {
                SplashKit.ProcessEvents();
                SplashKit.Delay(100);
            }
        }
        else
        {
            System.Console.WriteLine($"Window '{windowName}' not found.");
        }
    }
}
