using SplashKitSDK;

namespace LaserShieldIntersectionExample
{
    public class Program
    {
        public static void Main()
        {
            // Open a window
            Window window = new Window("Laser Passing Through Shield", 800, 600);

            // Fixed player position
            Point2D playerPosition = SplashKit.PointAt(0, 0);

            // Shield represented by a circle
            Circle shield = new Circle()
            {
                Center = SplashKit.PointAt(400, 300),
                Radius = 100
            };

            // Points for entry and exit on the shield
            Point2D entryPoint = SplashKit.PointAt(0, 0);
            Point2D exitPoint = SplashKit.PointAt(0, 0);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                // Draw the shield
                SplashKit.DrawCircle(Color.Blue, shield);

                // Get current mouse position
                Point2D aimPoint = SplashKit.MousePosition();

                // Draw aiming laser
                SplashKit.DrawLine(Color.Red, playerPosition, aimPoint);

                // Calculate laser heading
                Vector2D heading = SplashKit.UnitVector(SplashKit.VectorPointToPoint(playerPosition, aimPoint));

                // Find entry point (first intersection)
                float entryDistance = SplashKit.RayCircleIntersectDistance(playerPosition, heading, shield);

                if (entryDistance > 0)
                {
                    // Draw entry point
                    entryPoint = SplashKit.PointAt(
                        playerPosition.X + heading.X * entryDistance,
                        playerPosition.Y + heading.Y * entryDistance
                    );
                    SplashKit.FillCircle(Color.Orange, entryPoint.X, entryPoint.Y, 5);

                    // Find exit point using distant_point_on_circle_heading
                    if (SplashKit.DistantPointOnCircleHeading(playerPosition, shield, heading, ref exitPoint))
                    {
                        SplashKit.FillCircle(Color.Green, exitPoint.X, exitPoint.Y, 5);

                        // Draw line between entry and exit
                        SplashKit.DrawLine(Color.Purple, entryPoint, exitPoint);
                    }
                }

                SplashKit.RefreshScreen(60);
            }
        }
    }
}
