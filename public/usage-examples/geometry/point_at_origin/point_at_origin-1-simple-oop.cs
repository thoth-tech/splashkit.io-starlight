using SplashKitSDK;

namespace PointAt
{
    public class Program
    {
        public static void Main()
        {
        SplashKit.OpenWindow("Point At Origin", 800, 600);
        SplashKit.ClearScreen();

        // Create a point at origin
        Point2D Point = SplashKit.PointAtOrigin();

        // Create circle at the origin point
        SplashKit.FillCircle(Color.Red, Point.X, Point.Y, 4);

        SplashKit.RefreshScreen();
        SplashKit.Delay(4000);
        SplashKit.CloseAllWindows();
        }
    }
}

