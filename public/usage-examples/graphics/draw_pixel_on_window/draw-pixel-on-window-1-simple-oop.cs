using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Open a window titled "Falling Snow" with a size of 800x600
        Window window = SplashKit.OpenWindow("Falling Snow", 800, 600);

        // Loop until the user requests to quit
        while (!SplashKit.QuitRequested())
        {
            // Generate random X and Y coordinates
            double x = SplashKit.Rnd(0, 800);  // Random X position
            double y = SplashKit.Rnd(0, 600);  // Random Y position

            // Draw 100 random pixels on the window
            for (int i = 0; i < 100; i++)
            {
                SplashKit.DrawPixelOnWindow(window, Color.Gray, x, y);
            }
            // Refresh the screen to show the drawn pixels
            SplashKit.RefreshScreen();
            
            // Delay to control the frame rate
            SplashKit.Delay(50);
        }

        // Close all windows
        SplashKit.CloseAllWindows();
    }
}
