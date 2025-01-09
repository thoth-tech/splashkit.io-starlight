using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Open a new window with the title "Bitmap Scaling" and dimensions 800x600
        Window window = SplashKit.OpenWindow("Bitmap Scaling", 800, 600);

        // Load the bitmap from the file "landscape.png" and give it the name "Landscape"
        Bitmap bmp = SplashKit.LoadBitmap("Landscape", "landscape.png");

        // Set the scaling factors for the bitmap
        double scaleX = 0.5; // Scale the width to 50% of the original size
        double scaleY = 0.5; // Scale the height to 50% of the original size

        // Draw the scaled bitmap onto the window at coordinates (100, 100)
        SplashKit.DrawBitmap(bmp, 100, 100, SplashKit.OptionScaleBmp(scaleX, scaleY));

        // Refresh the screen to display the changes
        SplashKit.RefreshScreen();

        // Pause the program for 3000 milliseconds (3 seconds)
        SplashKit.Delay(3000);

        // Free the memory used by the bitmap
        SplashKit.FreeBitmap(bmp);

        // Close all open windows        
        SplashKit.CloseAllWindows();
    }
}

