using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window window = SplashKit.OpenWindow("Option Flip Y ", 600, 600);

        Bitmap bmp = SplashKit.LoadBitmap("Landscape", "landscape.png");

        // Draw the original bitmap image at position (100, 300)
        SplashKit.DrawBitmap(bmp, 100, 300); 

        // Draw the bitmap image flipped horizontally at position (400, 300)
        SplashKit.DrawBitmap(bmp, 400, 300, SplashKit.OptionFlipY());

        SplashKit.RefreshScreen();

        SplashKit.Delay(5000);

        SplashKit.CloseAllWindows();
    }
}
