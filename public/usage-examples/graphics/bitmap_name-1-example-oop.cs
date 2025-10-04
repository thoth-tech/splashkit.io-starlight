using SplashKitSDK;

namespace BitmapNameExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Bitmap Name", 800, 600);

            Bitmap imageBitmap = SplashKit.LoadBitmap("insert_name_here", "image1.jpg");

            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawBitmap(imageBitmap, 200, 155);
            SplashKit.DrawText("The name of the above bitmap is '" + SplashKit.BitmapName(imageBitmap) + "'", Color.Black, 215, 450);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}