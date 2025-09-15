using SplashKitSDK;

namespace OptionPartBmpExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Halved Image Generator", 800, 600);

            Bitmap imageBitmap = SplashKit.LoadBitmap("image_bitmap", "image1.jpg");

            SplashKit.ClearScreen(Color.White);
            // A bitmap is drawn with the 'option_part_bmp' function included in its drawing options
            SplashKit.DrawBitmap(imageBitmap, 200, 155, SplashKit.OptionPartBmp(0, 0, SplashKit.BitmapWidth(imageBitmap) / 2, SplashKit.BitmapHeight(imageBitmap)));
            SplashKit.DrawText("A portion of this bitmap has been drawn", Color.Black, 215, 450);
            SplashKit.DrawText("In this example, half of the bitmap (width-wise)", Color.Black, 214, 465);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}