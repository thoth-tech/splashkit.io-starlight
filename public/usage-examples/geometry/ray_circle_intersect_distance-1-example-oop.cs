using SplashKitSDK;

namespace RayCircleIntersectDistanceExample
{
    public class Program
    {
        public static void Main()
        {
            // Ppens a new window
            Window window = new Window("Distance From Ray To Circle", 800, 600);

            // Defines a laser beam from the left edge of the screen to the right
            Point2D rayOrigin = SplashKit.PointAt(0, 300);
            Point2D rayEnd = SplashKit.PointAt(800, 100);
            Vector2D rayDirection = SplashKit.UnitVector(SplashKit.VectorTo(rayEnd));

            // Defines a circle at the center with radius 100
            Circle circleObj = new Circle()
            {
                Center = SplashKit.PointAt(400, 300),
                Radius = 100
            };

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ClearScreen();

                // Draws the laser beam as a blue line
                SplashKit.DrawLine(Color.Blue, rayOrigin, rayEnd);

                // Draws the circle target in red
                SplashKit.DrawCircle(Color.Red, circleObj);

                // Checks for collision between the ray and the circle
                float distance = SplashKit.RayCircleIntersectDistance(rayOrigin, rayDirection, circleObj);

                // Displays the distance to the circle
                SplashKit.DrawText($"Distance to circle: {distance}", Color.Black, 100, 100);

                SplashKit.RefreshScreen(60);
            }
        }
    }
}