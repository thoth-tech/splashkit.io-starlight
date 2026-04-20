using SplashKitSDK;

namespace BitmapCollisionsDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            SplashKit.OpenWindow("Bitmap Collisions", 315, 330);

            // Load the bitmap and set its location
            Bitmap skBmp = SplashKit.LoadBitmap("skbox", "skbox.png");
            Point2D bmpLoc = new Point2D() { X = 50, Y = 50 };

            // Define the rectangles
            Rectangle blackRectangle = new Rectangle()
            {
                X = 20,
                Y = 20,
                Width = 20,
                Height = 20
            };

            Rectangle redRectangle = new Rectangle()
            {
                X = 150,
                Y = 200,
                Width = 20,
                Height = 20
            };

            // Clear the screen and draw the elements
            SplashKit.ClearScreen(SplashKit.RGBColor(67, 80, 175));
            SplashKit.DrawBitmap(skBmp, bmpLoc.X, bmpLoc.Y);
            SplashKit.FillRectangle(Color.Black, blackRectangle);
            SplashKit.FillRectangle(Color.Red, redRectangle);

            // Check for collisions
            if (SplashKit.BitmapRectangleCollision(skBmp, 50, 50, blackRectangle))
            {
                SplashKit.WriteLine("Black Rectangle Collision!");
            }

            if (SplashKit.BitmapRectangleCollision(skBmp, 50, 50, redRectangle))
            {
                SplashKit.WriteLine("Red Rectangle Collision!");
            }

            // Refresh the screen and wait
            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);

            // Close all windows
            SplashKit.CloseAllWindows();
        }
    }
}
