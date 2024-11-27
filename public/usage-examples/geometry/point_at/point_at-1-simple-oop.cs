using SplashKitSDK;

namespace PointAt
{
    public class Program
    {
        public static void Main()
        {
        SplashKit.OpenWindow("Point At", 800, 600);
        SplashKit.ClearScreen();

        // Draw the circle at the point
        SplashKit.FillCircle(Color.Red, 400, 300, 4);

        // Create a point at position (400,300)
        Point2D Point = SplashKit.PointAt(400, 300);

        SplashKit.RefreshScreen();
        SplashKit.Delay(4000);
        SplashKit.CloseAllWindows();
        }
    }
}

