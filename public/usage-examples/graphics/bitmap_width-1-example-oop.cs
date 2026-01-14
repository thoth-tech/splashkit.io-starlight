using SplashKitSDK;

namespace BitmapWidthExample
{
    public class Program
    {
        public static void Main()
        {
            Bitmap imageBitmap = SplashKit.LoadBitmap("imageBitmap", "image1.jpg");

            Window programWindow = SplashKit.OpenWindow("Bitmap Width", SplashKit.BitmapWidth(imageBitmap) + 200, SplashKit.BitmapHeight(imageBitmap) + 200);

            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawBitmap(imageBitmap, (SplashKit.WindowWidth(programWindow) - SplashKit.BitmapWidth(imageBitmap)) / 2, (SplashKit.WindowHeight(programWindow) - SplashKit.BitmapHeight(imageBitmap)) / 2);
            SplashKit.DrawText($"The above bitmap is {SplashKit.BitmapWidth(imageBitmap)} pixels in width", Color.Black, (SplashKit.WindowWidth(programWindow) - SplashKit.BitmapWidth(imageBitmap)) / 2, SplashKit.WindowHeight(programWindow) - 70);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}