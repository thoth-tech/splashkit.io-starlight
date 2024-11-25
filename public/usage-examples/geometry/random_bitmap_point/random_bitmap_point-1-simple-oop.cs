using SplashKitSDK;

namespace RandomBitmapPoint
{
    public class Program
    {
        public static void Main()
        {   
            //Create Window
            SplashKit.OpenWindow("random bitmap point", 600, 600);
            Bitmap bmp = new Bitmap("random quads",600,600);

            // create quad using random points on bitmap
            Quad q = SplashKit.QuadFrom(
                SplashKit.RandomBitmapPoint(bmp),
                SplashKit.RandomBitmapPoint(bmp),
                SplashKit.RandomBitmapPoint(bmp),
                SplashKit.RandomBitmapPoint(bmp));
            SplashKit.DrawQuadOnBitmap(bmp, Color.Black, q);

            SplashKit.ClearScreen(Color.WhiteSmoke);

            //Draw the bitmap
            SplashKit.DrawBitmap(bmp, 0,0);

            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);
            SplashKit.CloseAllWindows();
        }
    }
}
