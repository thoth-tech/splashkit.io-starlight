using SplashKitSDK;

namespace BitmapCenterExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Bitmap Center", 800, 600);

            Bitmap image_bitmap = SplashKit.LoadBitmap("image_bitmap", "image1.jpg");

            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawBitmap(image_bitmap, 0, 0);
            SplashKit.FillCircle(Color.Red, SplashKit.CircleAt(SplashKit.BitmapCenter(image_bitmap), 5));
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}