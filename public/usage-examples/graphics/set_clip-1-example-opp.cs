using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        SplashKit.OpenWindow("Set Clip Example", 600, 600);

        // Define a rectangle as the clip area
        Rectangle clipRect = SplashKit.RectangleFrom(100, 100, 400, 200);

        // Set the clip rectangle for the current window
        SplashKit.SetClip(clipRect);

        // Draw a background so we can see the clip area
        SplashKit.ClearScreen(Color.White);

        // Draw the outline of the clip area for visualization
        SplashKit.DrawRectangle(Color.Black, clipRect);

        // Only the part of the red rectangle inside the clip will be visible
        SplashKit.FillRectangle(Color.Red, 50, 50, 500, 300);

        // Draw a circle; only the part inside the clip area will be visible
        SplashKit.FillCircle(Color.Blue, 300, 200, 150);

        SplashKit.RefreshScreen();
        SplashKit.Delay(3000);

        // Remove the clipping (restore drawing to full window)
        SplashKit.PopClip();

        // Draw more shapes, now visible everywhere
        SplashKit.FillRectangle(Color.Green, 0, 500, 600, 80);

        SplashKit.RefreshScreen();
        SplashKit.Delay(2000);

        SplashKit.CloseAllWindows();
    }
}
