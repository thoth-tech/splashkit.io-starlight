using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Create and open a new window
        Window window = SplashKit.OpenWindow("Line Width Example", 800, 600);

        // Set line width to 10
        SplashKit.OptionLineWidth(10);
        SplashKit.DrawRectangle(Color.Black, 100, 100, 200, 150);

        // Set line width to 5
        SplashKit.OptionLineWidth(5);
        SplashKit.DrawRectangle(Color.Red, 400, 100, 200, 150);

        SplashKit.RefreshScreen();

        // Keep the window open until the user closes it
        while (!SplashKit.WindowCloseRequested(window))
        {
            SplashKit.ProcessEvents();
        }
    }
}
