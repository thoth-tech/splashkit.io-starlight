using SplashKitSDK;

namespace RayCircleIntersectDistanceExample
{
    public class Program
    {
        public static void Main()
        {
            // opens a new 800 * 600 window
            Window window = new Window("Distance From Ray To Circle", 800, 600);

            // sets the starting point of the ray on the left side of the screen
            Point2D rayOrigin = SplashKit.PointAt(0, 300);

            // sets the ending point of the ray on the right side of the screen
            Point2D rayEnd = SplashKit.PointAt(800, 100);

            // creates a direction vector pointing toward the right and slightly up
            Vector2D rayDirection = SplashKit.UnitVector(SplashKit.VectorTo(rayEnd));

            // creates a red circle at the center with radius 100
            Circle circleObj = new Circle()
            {
                Center = SplashKit.PointAt(400, 300),
                Radius = 100
            };

            // runs the loop until the user requests to quit
            while (!SplashKit.QuitRequested())
            {
                // fills the background with white
                SplashKit.ClearScreen(Color.White);

                // draws the laser beam as a blue line
                SplashKit.DrawLine(Color.Blue, rayOrigin, rayEnd);

                // draws the circle target in red
                SplashKit.DrawCircle(Color.Red, circleObj);

                // checks for collision between the ray and the circle
                float distance = SplashKit.RayCircleIntersectDistance(rayOrigin, rayDirection, circleObj);

                // displays the distance to the circle
                SplashKit.DrawText($"Distance to circle: {distance}", Color.Black, 100, 100);

                SplashKit.RefreshScreen(60);
            }
        }
    }
}