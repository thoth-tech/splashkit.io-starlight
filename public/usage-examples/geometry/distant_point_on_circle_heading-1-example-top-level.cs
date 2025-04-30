using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Clear the screen with white color
        SplashKit.ClearScreen(Color.White);

        // Define the circle's center and radius
        Point2D center = SplashKit.PointAt(400, 300);
        float radius = 100;
        float heading = 90;
        
        // Define the point of reference for calculation (can use (0,0) for simplicity)
        Point2D fromPoint = SplashKit.PointAt(100, 100);

        // Calculate the distant point on the circle at the given heading
        Point2D farPoint = SplashKit.DistantPointOnCircleHeading(center, radius, fromPoint, heading);

        // Draw the circle and the calculated point
        SplashKit.DrawCircle(Color.Blue, center, radius);
        SplashKit.DrawPixel(Color.Red, farPoint);

        // Refresh the screen to display changes at 60 FPS
        SplashKit.RefreshScreen(60);

        // Delay for 5000 milliseconds to keep the window open
        SplashKit.Delay(5000);
    }
}
