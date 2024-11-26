using SplashKitSDK;

namespace BitmapCollisionsApp
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Bitmap Collisions", 315, 330);

            Bitmap skBmp = SplashKit.LoadBitmap("skbox", "skbox.png");
            Point2D bmpLoc = new Point2D() { X = 50, Y = 50 };

            Circle blackCircle = new Circle()
            {
                Center = new Point2D() { X = 20, Y = 20 },
                Radius = 20
            };

            Circle redCircle = new Circle()
            {
                Center = new Point2D() { X = 150, Y = 150 },
                Radius = 20
            };

            SplashKit.ClearScreen(SplashKit.RGBColor(67, 80, 175));
            SplashKit.DrawBitmap(skBmp, bmpLoc.X, bmpLoc.Y);
            SplashKit.DrawCircle(SplashKit.ColorBlack(), blackCircle);
            SplashKit.DrawCircle(SplashKit.ColorRed(), redCircle);

            if (SplashKit.BitmapCircleCollision(skBmp, bmpLoc, blackCircle))
            {
                SplashKit.WriteLine("Black Circle Collision!");
            }

            if (SplashKit.BitmapCircleCollision(skBmp, bmpLoc, redCircle))
            {
                SplashKit.WriteLine("Red Circle Collision!");
            }

            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}
