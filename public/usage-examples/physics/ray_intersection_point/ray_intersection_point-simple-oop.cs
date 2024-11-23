using SplashKitSDK;
using static SplashKitSDK.SplashKit;

namespace RayIntersectionDemo
{
    public class Program
    {
        public static void Main()
        {
            // Define the ray
            Point2D rayOrigin = new Point2D() { X = 200, Y = 200 };
            Vector2D rayVector = VectorFromAngle(45, 150);
            Line rayLine = LineFrom(rayOrigin, rayVector);

            // Define the walls
            Point2D redStart = new Point2D() { X = 100, Y = 300 };
            Point2D redEnd = new Point2D() { X = 300, Y = 300 };
            Line redWall = LineFrom(redStart, redEnd);

            Point2D blackStart = new Point2D() { X = 100, Y = 100 };
            Point2D blackEnd = new Point2D() { X = 300, Y = 100 };
            Line blackWall = LineFrom(blackStart, blackEnd);

            // Open the window
            OpenWindow("Ray Intersection", 400, 400);

            // Visualize the scene
            ClearScreen(ColorWhite());
            WriteLine("Drawing Blue Ray");
            DrawLine(ColorBlue(), rayLine);

            WriteLine("Drawing Red and Black Walls");
            DrawLine(ColorRed(), redWall);
            DrawLine(ColorBlack(), blackWall);

            // Check for ray-wall intersections
            Point2D collisionPoint1 = new Point2D();
            Point2D collisionPoint2 = new Point2D();

            if (RayIntersectionPoint(rayOrigin, rayVector, redWall, ref collisionPoint1))
            {
                WriteLine("Collision with red wall at: " + PointToString(collisionPoint1));
                FillCircle(ColorGreen(), CircleAt(collisionPoint1, 4));
            }
            else
            {
                WriteLine("No collision with red wall.");
            }

            if (RayIntersectionPoint(rayOrigin, rayVector, blackWall, ref collisionPoint2))
            {
                WriteLine("Collision with black wall at: " + PointToString(collisionPoint2));
                FillCircle(ColorGreen(), CircleAt(collisionPoint2, 4));
            }
            else
            {
                WriteLine("No collision with black wall.");
            }

            // Refresh the screen and wait
            RefreshScreen();
            Delay(5000);
            CloseAllWindows();
        }
    }
}
