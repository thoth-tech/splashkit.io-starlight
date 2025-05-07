using SplashKitSDK;

namespace DistantPointOnCircleHeadingExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Laser Passing Through Shield", 800, 600);

            // Declare variables
            Point2D playerPosition = SplashKit.PointAt(0, 0);
            Circle shield = SplashKit.CircleAt(400, 300, 100);
            Point2D aimPoint;
            Vector2D heading;
            float entryDistance;
            Point2D entryPoint;
            Point2D exitPoint = SplashKit.PointAt(0, 0);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Calculate laser heading using mouse position
                aimPoint = SplashKit.MousePosition();
                heading = SplashKit.UnitVector(SplashKit.VectorPointToPoint(playerPosition, aimPoint));

                // Calculate distance from player to shield and point of entry
                entryDistance = SplashKit.RayCircleIntersectDistance(playerPosition, heading, shield);
                entryPoint = SplashKit.PointAt(playerPosition.X + heading.X * entryDistance, playerPosition.Y + heading.Y * entryDistance);

                // Draw the shield (circle) and laser (line)
                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawCircle(Color.Blue, shield);
                SplashKit.DrawLine(Color.Red, playerPosition, aimPoint);

                if (entryDistance > 0)
                {
                    // Find exit point of laser
                    if (SplashKit.DistantPointOnCircleHeading(playerPosition, shield, heading, ref exitPoint))
                    {
                        // Draw entry and exit points and line between entry and exit
                        SplashKit.FillCircle(Color.Orange, entryPoint.X, entryPoint.Y, 5);
                        SplashKit.FillCircle(Color.Green, exitPoint.X, exitPoint.Y, 5);
                        SplashKit.DrawLine(Color.Purple, entryPoint, exitPoint);
                    }
                }
                SplashKit.RefreshScreen(60);
            }
        }
    }
}