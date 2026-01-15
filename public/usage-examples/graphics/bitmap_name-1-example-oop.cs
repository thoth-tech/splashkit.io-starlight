using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Create a new window with title and size
        Window window = new Window("Bitmap Named Example", 800, 600);

        // Load the bitmap and assign it a name "logo"
        SplashKit.LoadBitmap("logo", "splashkit.png");

        // Retrieve the bitmap using its name
        Bitmap image = SplashKit.BitmapNamed("logo");

        // Calculate the center position
        float x = (window.Width - SplashKit.BitmapWidth(image)) / 2;
        float y = (window.Height - SplashKit.BitmapHeight(image)) / 2;

        // Clear the screen with white background
        SplashKit.ClearScreen(Color.White);

        // Draw the bitmap centered on the window
        SplashKit.DrawBitmap(image, x, y);

        // Output the bitmap name to the terminal
        SplashKit.WriteLine("Bitmap name: " + SplashKit.BitmapName(image));

        // Display the result at 60 FPS
        SplashKit.RefreshScreen(60);

        // Pause to show the result
        SplashKit.Delay(3000);
    }
}