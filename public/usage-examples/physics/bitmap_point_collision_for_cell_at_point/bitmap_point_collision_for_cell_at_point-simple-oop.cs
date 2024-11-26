using SplashKitSDK;

namespace BitmapCollisionsDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            SplashKit.OpenWindow("Bitmap Collisions", 315, 330);

            // Load the bitmap
            Bitmap skBmp = SplashKit.LoadBitmap("skbox", "skbox.png");

            // Set the bitmap and dot locations using Point2D
            Point2D skBmpLoc = new Point2D() { X = 50, Y = 50 };
            Point2D blackDotLoc = new Point2D() { X = 20, Y = 20 };
            Point2D redDotLoc = new Point2D() { X = 200, Y = 150 };

            // Clear the screen and draw the bitmap and dots
            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawBitmap(skBmp, skBmpLoc.X, skBmpLoc.Y);
            SplashKit.FillCircle(Color.Black, SplashKit.CircleAt(blackDotLoc, 2));
            SplashKit.FillCircle(Color.Red, SplashKit.CircleAt(redDotLoc, 2));

            // Check for collisions
            if (SplashKit.BitmapPointCollision(skBmp, 20, skBmpLoc, blackDotLoc))
            {
                SplashKit.WriteLine("Black Dot Collision");
            }

            if (SplashKit.BitmapPointCollision(skBmp, 200, skBmpLoc, redDotLoc))
            {
                SplashKit.WriteLine("Red Dot Collision!");
            }

            // Refresh the screen and wait
            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);

            // Close all windows
            SplashKit.CloseAllWindows();
        }
    }
}
