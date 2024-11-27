using SplashKitSDK;

namespace PointAt
{
    public class Program
    {
        public static void Main()
        {
        SplashKit.OpenWindow("Point At Origin", 800, 600);
        SplashKit.ClearScreen();

        // Create circle at the origin point
        SplashKit.FillCircle(Color.Red, 0, 0, 4);

        // Create a point at origin
        Point2D Point = SplashKit.PointAtOrigin();

        SplashKit.RefreshScreen();
        SplashKit.Delay(4000);
        SplashKit.CloseAllWindows();
        }
    }
}

