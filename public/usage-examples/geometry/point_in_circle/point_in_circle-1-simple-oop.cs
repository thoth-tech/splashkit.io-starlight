using SplashKitSDK;

namespace PointInCircle
{
    public class Program
    {
        public static void Main()
        {
            // Let user create a circle
            SplashKit.WriteLine("Create a circle!");
            SplashKit.WriteLine("Center point x1: ");
            int x1 = SplashKit.ConvertToInteger(SplashKit.ReadLine());
            SplashKit.WriteLine("Center point y1: ");
            int y1 = SplashKit.ConvertToInteger(SplashKit.ReadLine());
            SplashKit.WriteLine("Radius for circle: ");
            int radius = SplashKit.ConvertToInteger(SplashKit.ReadLine());

            // Let user create a point
            SplashKit.WriteLine("Create a point now!");
            SplashKit.WriteLine("x for point: ");
            int px1 = SplashKit.ConvertToInteger(SplashKit.ReadLine());
            SplashKit.WriteLine("y for point: ");
            int py1 = SplashKit.ConvertToInteger(SplashKit.ReadLine());

            SplashKit.OpenWindow("Point In Circle", 800, 600);
            SplashKit.ClearScreen();

            // Create the circle base on the data given by user
            Circle A = SplashKit.CircleAt(x1, y1, radius);

            // Create the point base on the data given by user
            Point2D B = SplashKit.PointAt(px1, py1);

            // Draw the circle
            SplashKit.DrawCircle(SplashKit.ColorRed(), A);

            // Draw the point
            SplashKit.FillCircle(SplashKit.ColorGreen(), px1, py1, 4);

            // Detect if the point in the circle or not
            if (SplashKit.PointInCircle(B, A))
            {
                SplashKit.WriteLine("Point in the circle!");
            }
            else
            {
                SplashKit.WriteLine("Point not in the circle!");
            }

            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}

