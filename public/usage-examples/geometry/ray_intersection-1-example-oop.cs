// Demonstrates ray_circle_intersect_distance by drawing a ray and a circle.
// Shows the distance from the ray origin to the intersection point on the circle.

using SplashKitSDK;

public class RayCircleExample
{
    public static void Main()
    {
        SplashKit.OpenWindow("Ray-Circle Intersection", 600, 400);

        Point2D origin = SplashKit.PointAt(300, 200);
        Vector2D direction = SplashKit.VectorTo(1, 0);
        Ray r = SplashKit.RayFromPointAndDirection(origin, direction);
        Circle c = SplashKit.CircleAt(400, 200, 50);

        float dist = SplashKit.RayCircleIntersectDistance(r, c);

        SplashKit.ClearScreen(Color.White);
        SplashKit.DrawCircle(Color.Red, c);
        SplashKit.DrawLine(Color.Blue, r.Origin, SplashKit.PointAt(r.Origin.X + 600, r.Origin.Y));

        if (dist >= 0)
        {
            Point2D hit = SplashKit.PointAt(r.Origin.X + direction.X * dist, r.Origin.Y + direction.Y * dist);
            SplashKit.DrawCircle(Color.Green, hit.X, hit.Y, 5);
        }

        SplashKit.RefreshScreen();
        SplashKit.Delay(3000);
    }
}
