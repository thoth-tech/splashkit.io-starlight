using SplashKitSDK;

public class RayCircleIntersectDistanceExample
{
    public void Run()
    {
        // opens a new 800 * 600 window
        Window window = new Window("Ray-Circle Intersect Distance", 800, 600);

        // sets the starting point of the ray on the left side of the screen
        Point2D rayOrigin = SplashKit.PointAt(100, 200);

        // creates a direction vector pointing toward the right and slightly down
        Vector2D rayDirection = SplashKit.UnitVector(SplashKit.VectorTo(SplashKit.PointAt(700, 300)));

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

            // computes the laser's end point by scaling the direction vector
            Point2D rayEnd = SplashKit.PointOffsetBy(rayOrigin, SplashKit.VectorMultiply(rayDirection, 800));

            // draws the laser beam as a blue line
            SplashKit.DrawLine(Color.Blue, rayOrigin, rayEnd);

            // draws the circle target in red
            SplashKit.DrawCircle(Color.Red, circleObj.Center.X, circleObj.Center.Y, circleObj.Radius);

            // checks for collision between the ray and the circle
            float distance = SplashKit.RayCircleIntersectDistance(rayOrigin, rayDirection, circleObj);

            // if collision occurs, calculate and show the hit point with a green dot
            if (distance > 0)
            {
                Vector2D scaled = SplashKit.VectorMultiply(rayDirection, distance);
                Point2D hitPoint = SplashKit.PointOffsetBy(rayOrigin, scaled);
                SplashKit.FillCircle(Color.Green, hitPoint.X, hitPoint.Y, 5);
            }

            // refreshes the screen at 60 FPS
            SplashKit.RefreshScreen(60);
        }
    }

    public static void Main()
    {
        new RayCircleApp().Run();
    }
}
