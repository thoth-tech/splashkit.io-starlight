using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Open a new window with the title "Option Flip X" 
        Window window = SplashKit.OpenWindow("Option Flip X ", 600, 600);

        // Load a bitmap image named "Player" from the file "character.png"
        Bitmap bmp = SplashKit.LoadBitmap("Player", "character.png");

        // Draw the original bitmap image at position (100, 300) in the window
        SplashKit.DrawBitmap(bmp, 100, 300); 

        // Draw the bitmap image flipped horizontally at position (500, 300)
        SplashKit.DrawBitmap(bmp, 500, 300, SplashKit.OptionFlipX());

        // Refresh the screen to display the drawings
        SplashKit.RefreshScreen();

        // Wait for 5 seconds before closing the window
        SplashKit.Delay(5000);

        // Close all open windows
        SplashKit.CloseAllWindows();
    }
}
