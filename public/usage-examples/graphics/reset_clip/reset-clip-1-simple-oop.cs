using SplashKitSDK;

public class Program
{
    public static void Main()
    {   
        // Open a window with the title "Reset Clip" and dimensions 800x600
        Window window= SplashKit.OpenWindow("Reset Clip", 800, 600);
        Rectangle rectangle = SplashKit.RectangleFrom(100, 100, 600, 400);
        // Set a clipping area
        SplashKit.SetClip(window, rectangle);

        // Draw inside the clipping area (will be clipped)
        SplashKit.FillRectangle(Color.Blue, 50, 50, 700, 500);  // This will be clipped
        SplashKit.RefreshScreen();
        SplashKit.Delay(1000);

        // Draw outside the clipping area (still within the clipped area, so it will be clipped)
        SplashKit.FillRectangle(Color.Red, 100, 100, 200, 200);  
        SplashKit.RefreshScreen();
        SplashKit.Delay(1000);

        // Reset the clipping area
        SplashKit.ResetClip();
        SplashKit.ClearScreen(Color.Green);  // Clear the screen with a new background color
        SplashKit.RefreshScreen();  // Refresh the screen to apply changes
        SplashKit.Delay(5000);  // Wait for 5 seconds to observe the result

        // Close the window
        SplashKit.CloseAllWindows();
    }
}
