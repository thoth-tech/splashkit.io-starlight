using SplashKitSDK;

namespace BitmapCollisionsApp
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            SplashKit.OpenWindow("Bitmap Collisions", 315, 330);

            // Load the bitmap and set its position
            Bitmap skBmp = SplashKit.LoadBitmap("skbox", "skbox.png");
            Point2D bmpLoc = new Point2D() { X = 50, Y = 50 };

            // Define the circles and their positions
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

            // Clear the screen and draw the elements
            SplashKit.ClearScreen(SplashKit.RGBColor(67, 80, 175));
            SplashKit.DrawBitmap(skBmp, bmpLoc.X, bmpLoc.Y);
            SplashKit.DrawCircle(SplashKit.ColorBlack(), blackCircle);
            SplashKit.DrawCircle(SplashKit.ColorRed(), redCircle);

            // Check for collisions and display messages
            if (SplashKit.BitmapCircleCollision(skBmp, 50, 50, blackCircle))
            {
                SplashKit.WriteLine("Black Circle Collision!");
            }

            if (SplashKit.BitmapCircleCollision(skBmp, 50, 50, redCircle))
            {
                SplashKit.WriteLine("Red Circle Collision!");
            }

            // Refresh the screen, wait, and close the window
            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}
