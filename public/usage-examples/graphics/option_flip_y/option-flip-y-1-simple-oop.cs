using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Open a new window with the title "OptionFlipY Demo" and dimensions 800x600
        Window window = SplashKit.OpenWindow("Option Flip Y ", 800, 600);

        // Load a bitmap image named "Player" from the file "character.png"
        Bitmap bmp = SplashKit.LoadBitmap("Landscape", "landscape.png");

        // Draw the original bitmap image at position (100, 100) in the window
        SplashKit.DrawBitmap(bmp, 100, 100); 

        // Draw the bitmap image flipped horizontally at position (300, 100)
        SplashKit.DrawBitmap(bmp, 300, 100, SplashKit.OptionFlipY());

        // Refresh the screen to display the drawings
        SplashKit.RefreshScreen();

        // Pause the program for 5000 milliseconds (5 seconds) to keep the window open
        SplashKit.Delay(5000);

        // Close all open windows
        SplashKit.CloseAllWindows();
    }
}
