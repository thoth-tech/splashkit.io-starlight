using SplashKitSDK;

namespace OptionScaleBmpExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Option Scale Bmp", 800, 600);

            Bitmap imageBitmap = SplashKit.LoadBitmap("image_bitmap", "image1.jpg");

            SplashKit.ClearScreen(Color.White);
            // Function used here ↓
            SplashKit.DrawBitmap(imageBitmap, 200, 130, SplashKit.OptionScaleBmp(1.5, 1.5));
            SplashKit.DrawText("This bitmap has been made 50 percent larger than normal", Color.Black, 180, 470);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}