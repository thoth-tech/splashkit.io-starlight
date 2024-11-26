using SplashKitSDK;

namespace RayIntersectionDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the ray
            Point2D rayOrigin = new Point2D() { X = 200, Y = 200 };
            Vector2D rayVector = SplashKit.VectorFromAngle(45, 150);
            Line rayLine = SplashKit.LineFrom(rayOrigin, rayVector);

            // Define the walls
            Point2D redStart = new Point2D() { X = 100, Y = 300 };
            Point2D redEnd = new Point2D() { X = 300, Y = 300 };
            Line redWall = SplashKit.LineFrom(redStart, redEnd);

            Point2D blackStart = new Point2D() { X = 100, Y = 100 };
            Point2D blackEnd = new Point2D() { X = 300, Y = 100 };
            Line blackWall = SplashKit.LineFrom(blackStart, blackEnd);

            // Open the window
            SplashKit.OpenWindow("Ray Intersection", 400, 400);

            // Visualize the scene
            SplashKit.ClearScreen(SplashKit.ColorWhite());
            SplashKit.WriteLine("Drawing Blue Ray");
            SplashKit.DrawLine(SplashKit.ColorBlue(), rayLine);

            SplashKit.WriteLine("Drawing Red and Black Walls");
            SplashKit.DrawLine(SplashKit.ColorRed(), redWall);
            SplashKit.DrawLine(SplashKit.ColorBlack(), blackWall);

            // Check for ray-wall intersections
            Point2D collisionPoint1 = new Point2D();
            Point2D collisionPoint2 = new Point2D();

            if (SplashKit.RayIntersectionPoint(rayOrigin, rayVector, redWall, ref collisionPoint1))
            {
                SplashKit.WriteLine("Collision with red wall at: " + SplashKit.PointToString(collisionPoint1));
                SplashKit.FillCircle(SplashKit.ColorGreen(), SplashKit.CircleAt(collisionPoint1, 4));
            }
            else
            {
                SplashKit.WriteLine("No collision with red wall.");
            }

            if (SplashKit.RayIntersectionPoint(rayOrigin, rayVector, blackWall, ref collisionPoint2))
            {
                SplashKit.WriteLine("Collision with black wall at: " + SplashKit.PointToString(collisionPoint2));
                SplashKit.FillCircle(SplashKit.ColorGreen(), SplashKit.CircleAt(collisionPoint2, 4));
            }
            else
            {
                SplashKit.WriteLine("No collision with black wall.");
            }

            // Refresh the screen and wait
            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);
            SplashKit.CloseAllWindows();
        }
    }
}
