using SplashKitSDK;

namespace DistantPointOnCircleHeadingExample
{
    public class Program
    {
        public static void Main()
        {
            // Open the window for graphical output
            Window window = new Window("Distant Point Demo", 800, 600);
            SplashKit.ClearScreen(Color.White);

            // Define the circle's center and radius
            Point2D center = SplashKit.PointAt(400, 300);
            float radius = 100;

            // Define heading in degrees (0 = east, 90 = north, 180 = west, 270 = south)
            float heading = 90;

            // Define a reference point (can be set to (0,0) for simplicity)
            Point2D fromPoint = SplashKit.PointAt(0, 0);

            // Calculate the distant point on the circle at the given heading
            Point2D farPoint = SplashKit.DistantPointOnCircleHeading(center, radius, heading);

            // Draw the circle and the calculated point
            SplashKit.DrawCircle(Color.Blue, center, radius);
            SplashKit.DrawPixel(Color.Red, farPoint);

            // Display coordinates as optional debug info
            SplashKit.DrawText($"Point: ({farPoint.X:0.00}, {farPoint.Y:0.00})", Color.Black, 10, 10);

            // Refresh the screen to display changes at 60 FPS
            SplashKit.RefreshScreen(60);
            SplashKit.Delay(5000);

            // Close the window after the delay
            window.Close();
        }
    }
}
