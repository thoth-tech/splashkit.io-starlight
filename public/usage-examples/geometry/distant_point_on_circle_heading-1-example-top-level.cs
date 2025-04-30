using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        SplashKit.ClearScreen(Color.White);

        Point2D center = SplashKit.PointAt(400, 300);
        float radius = 100;
        float heading = 90;
        Point2D fromPoint = SplashKit.PointAt(100, 100);
        Point2D farPoint = SplashKit.DistantPointOnCircleHeading(center, radius, fromPoint, heading);

        SplashKit.DrawCircle(Color.Blue, center, radius);
        SplashKit.DrawPixel(Color.Red, farPoint);

        SplashKit.RefreshScreen(60);
        SplashKit.Delay(5000);
    }
}
