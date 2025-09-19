using SplashKitSDK;

namespace OptionRotateBmpExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Option Rotate Bmp", 800, 600);

            Bitmap imageBitmap = SplashKit.LoadBitmap("image_bitmap", "image1.jpg");
            int bitmap_rotation = 10;

            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawBitmap(imageBitmap, 200, 130, SplashKit.OptionRotateBmp(bitmap_rotation));
            SplashKit.DrawText("This bitmap has been rotated by " + bitmap_rotation.ToString() + " degrees", Color.Black, 215, 450);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}