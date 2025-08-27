using SplashKitSDK;

namespace OptionRotateBmpExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Option Rotate Bmp", 800, 600);

            Bitmap imageBitmap = SplashKit.LoadBitmap("image_bitmap", "image1.jpg");

            SplashKit.ClearScreen(Color.White);
            // Function used here ↓
            SplashKit.DrawBitmap(imageBitmap, 200, 130, SplashKit.OptionRotateBmp(10));
            SplashKit.DrawText("This bitmap has been rotated by +10 degrees", Color.Black, 215, 450);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}