using SplashKitSDK;

namespace BitmapWidthExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Bitmap Width", 800, 600);

            Bitmap imageBitmap = SplashKit.LoadBitmap("imageBitmap", "image1.jpg");

            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawBitmap(imageBitmap, 200, 155);
            SplashKit.DrawText($"The above bitmap is {SplashKit.BitmapWidth(imageBitmap)} pixels in width", Color.Black, 215, 450);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}