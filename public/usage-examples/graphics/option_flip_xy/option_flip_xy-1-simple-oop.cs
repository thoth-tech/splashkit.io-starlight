using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Open a new window with the title "OptionFlipXY" and dimensions 800x600
        Window window = SplashKit.OpenWindow("Option Flip XY ", 800, 600);

        // Load a bitmap image named "House" from the file "house.png"
        Bitmap bmp = SplashKit.LoadBitmap("House", "house.png");

        // Draw the original bitmap image at position (100, 100) in the window
        SplashKit.DrawBitmap(bmp, 100, 100); 

        // Draw the bitmap image flipped horizontally at position (300, 100)
        SplashKit.DrawBitmap(bmp, 300, 100, SplashKit.OptionFlipXy());

        // Refresh the screen to display the drawings
        SplashKit.RefreshScreen();

        // Pause the program for 5000 milliseconds (5 seconds) to keep the window open
        SplashKit.Delay(5000);

        // Close all open windows
        SplashKit.CloseAllWindows();
    }
}
