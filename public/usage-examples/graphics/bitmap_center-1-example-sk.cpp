using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window window = SplashKit.OpenWindow("Bitmap Center Example", 800, 600);

        // Load bitmap
        Bitmap img = SplashKit.LoadBitmap("example.png");

        // Get center of bitmap
        Point center = SplashKit.BitmapCenter(img);

        // Clear screen
        SplashKit.ClearScreen(Color.White);

        // Draw bitmap at its center
        SplashKit.DrawBitmap(img, center.X, center.Y);

        // Refresh screen
        SplashKit.RefreshScreen();

        // Wait for 3 seconds
        SplashKit.Delay(3000);
    }
}
