using SplashKitSDK;

namespace OptionPartBmpExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Option Part Bmp", 800, 600);

            Bitmap imageBitmap = SplashKit.LoadBitmap("image_bitmap", "image1.jpg");

            SplashKit.ClearScreen(Color.White);
            // Function used here ↓
            SplashKit.DrawBitmap(imageBitmap, 200, 155, SplashKit.OptionPartBmp(0, 0, 200, 249));
            SplashKit.DrawText("A portion of this bitmap has been drawn", Color.Black, 215, 450);
            SplashKit.DrawText("In this case, exactly half of it width-wise", Color.Black, 214, 465);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}