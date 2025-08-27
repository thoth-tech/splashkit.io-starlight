using SplashKitSDK;

namespace OptionFlipYExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Option Flip Y", 800, 600);

            Bitmap imageBitmap = SplashKit.LoadBitmap("image_bitmap", "image1.jpg");

            SplashKit.ClearScreen(Color.White);
            // Function used here ↓
            SplashKit.DrawBitmap(imageBitmap, 200, 155, SplashKit.OptionFlipY());
            SplashKit.DrawText("This bitmap has been flipped along it's Y axis", Color.Black, 215, 450);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}