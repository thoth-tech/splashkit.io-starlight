using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace RayIntersectionDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            OpenWindow("Ray Intersection", 300, 300);

            // Define the ray
            Point2D rayOrigin = new Point2D() { X = 150, Y = 150 };
            Vector2D rayVector = VectorFromAngle(45, 100);
            Line rayLine = LineFrom(rayOrigin, rayVector);

            // Define the walls
            Point2D redStart = new Point2D() { X = 150, Y = 200 };
            Point2D redEnd = new Point2D() { X = 300, Y = 200 };
            Line redWall = LineFrom(redStart, redEnd);

            Point2D blackStart = new Point2D() { X = 150, Y = 50 };
            Point2D blackEnd = new Point2D() { X = 200, Y = 50 };
            Line blackWall = LineFrom(blackStart, blackEnd);

            // Define collision points
            Point2D collisionPoint1 = new Point2D() { X = 250, Y = 250 };
            Point2D collisionPoint2 = new Point2D() { X = 250, Y = 125 };

            // Visualize the scene
            ClearScreen(ColorWhite());
            FillCircle(ColorBrown(), CircleAt(collisionPoint1, 2));
            FillCircle(ColorBrown(), CircleAt(collisionPoint2, 2));
            DrawLine(ColorBlue(), rayLine);
            DrawLine(ColorRed(), redWall);
            DrawLine(ColorBlack(), blackWall);

            // Check for ray-wall intersections
            if (RayIntersectionPoint(rayOrigin, rayVector, redWall, collisionPoint1))
                WriteLine("Collision with red wall!");
            if (RayIntersectionPoint(rayOrigin, rayVector, blackWall, collisionPoint2))
                WriteLine("Collision with black wall!");

            RefreshScreen();
            Delay(4000);
            CloseAllWindows();
        }
    }
}
