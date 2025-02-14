using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Open a window with the title "Set Clip" and dimensions 800x600
        Window window = SplashKit.OpenWindow("Set Clip", 800, 600);

        // Define a rectangle that will be used as the clipping area
        Rectangle rectangle = SplashKit.RectangleFrom(100, 100, 600, 400);

        // Push a clipping area onto the window
        SplashKit.SetClip(window, rectangle);

        // Draw a blue rectangle that will be clipped by the clipping area
        SplashKit.FillRectangle(Color.Blue, 50, 50, 700, 500);  // This will be clipped

        // Refresh the screen to display the drawing
        SplashKit.RefreshScreen();
        SplashKit.Delay(5000);  // Wait for 5 seconds to view the result

        // Close the window
        SplashKit.CloseAllWindows();
    }
}
