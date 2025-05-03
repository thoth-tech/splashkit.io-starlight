using SplashKitSDK;

namespace DistantPointOnCircleHeadingExample
{
    public class Program
    {
        public static void Main()
        {
            // Open a new 800x600 window
            Window window = new Window("Ray Exit Point From A Circle", 800, 600);

            // Define a laser beam starting from the top-left toward bottom-right
            Point2D rayOrigin = SplashKit.PointAt(0, 0);
            Point2D rayEnd = SplashKit.PointAt(800, 500);
            Vector2D rayDirection = SplashKit.UnitVector(SplashKit.VectorTo(rayEnd));

            // Create a circle centered in the window with radius 100
            Circle targetCircle = new Circle()
            {
                Center = SplashKit.PointAt(400, 300),
                Radius = 100
            };

            Point2D exitPoint = SplashKit.PointAt(0, 0);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ClearScreen(SplashKit.ColorWhite());

                // Draw the laser beam
                SplashKit.DrawLine(SplashKit.ColorRed(), rayOrigin, rayEnd);

                // Draw the target circle
                SplashKit.DrawCircle(SplashKit.ColorBlue(), targetCircle);

                // Try to find the exit point on the circle along the heading
                if (SplashKit.DistantPointOnCircleHeading(rayOrigin, targetCircle, rayDirection, ref exitPoint))
                {
                    // If a valid exit point is found, draw it
                    SplashKit.FillCircle(SplashKit.ColorGreen(), exitPoint.X, exitPoint.Y, 5);
                }

                SplashKit.RefreshScreen(60);
            }
        }
    }
}
