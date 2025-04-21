using SplashKitSDK;

// This program demonstrates the use of the distant_point_on_circle_heading function.
// It draws a circle and a point, then calculates and shows the farthest point
// on the circle in the direction away from the fixed point.

public class Program
{
    public static void Main()
    {
        Window window = new Window("Farthest Point", 400, 300);

        Circle c = new Circle() { Center = new Point2D() { X = 200, Y = 150 }, Radius = 50 };
        Point2D from = new Point2D() { X = 100, Y = 50 };

        Vector2D heading = new Vector2D(from.X - c.Center.X, from.Y - c.Center.Y);

        Point2D farPoint = new Point2D();
        SplashKit.DistantPointOnCircleHeading(from, c, heading, ref farPoint);

        while (!window.CloseRequested)
        {
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen(Color.White);

            SplashKit.DrawCircle(Color.Black, c);
            SplashKit.DrawPixel(Color.Red, from);
            SplashKit.DrawPixel(Color.Blue, farPoint);

            SplashKit.RefreshScreen(60);
        }
    }
}
