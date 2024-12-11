using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Open a window with the title "Push Clip" and dimensions 800x600
        Window window = SplashKit.OpenWindow("Push Clip", 800, 600);

        // Define a rectangular clipping area starting at (100, 100) with width 200 and height 200
        Rectangle rectangle = SplashKit.RectangleFrom(100, 100, 200, 200);

        // Push a clipping area on the window
        SplashKit.PushClip(window, rectangle);

        // Draw a blue rectangle inside the clipping area (this will be clipped by the clipping area)
        SplashKit.FillRectangle(Color.Blue, 50, 50, 300, 300);  // This will be clipped

        // Pop the clipping area to restore full screen drawing capability
        SplashKit.PopClip();

        // Draw a red rectangle outside the clipping area (this won't be clipped)
        SplashKit.FillRectangle(Color.Red,  300, 300, 200, 200);

        // Refresh the screen to display the drawing
        SplashKit.RefreshScreen();

        // Wait for 5 seconds to observe the changes
        SplashKit.Delay(5000);

        // Close all open windows to end the program
        SplashKit.CloseAllWindows();
    }
}
