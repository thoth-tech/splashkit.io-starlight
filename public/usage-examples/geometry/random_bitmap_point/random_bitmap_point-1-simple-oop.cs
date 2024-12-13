using SplashKitSDK;

namespace RandomBitmapPoint
{
    public class Program
    {
        public static void Main()
        {   
            // Create Window
            Window Window = new Window("Random Quad Shape", 600, 600);
            Bitmap Bmp = new Bitmap("Random Quads", 600, 600);

            // Create quad using random points on bitmap
            Quad Q = SplashKit.QuadFrom(
                SplashKit.RandomBitmapPoint(Bmp),
                SplashKit.RandomBitmapPoint(Bmp),
                SplashKit.RandomBitmapPoint(Bmp),
                SplashKit.RandomBitmapPoint(Bmp));
            Bmp.DrawQuad(Color.Black, Q);

            Window.Clear(Color.WhiteSmoke);

            // Draw the bitmap
            Window.DrawBitmap(Bmp, 0, 0);

            Window.Refresh();
            SplashKit.Delay(5000);
            Window.Close();
        }
    }
}