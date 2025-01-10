using SplashKitSDK;

namespace PointInTriangle
{
    public class Program
    {
        public static void Main()
        {
            // Let user create a triangle
            SplashKit.WriteLine("Create a triangle!");
            SplashKit.WriteLine("x1: ");
            int x1 = SplashKit.ConvertToInteger(SplashKit.ReadLine());
            SplashKit.WriteLine("y1: ");
            int y1 = SplashKit.ConvertToInteger(SplashKit.ReadLine());
            SplashKit.WriteLine("x2: ");
            int x2 = SplashKit.ConvertToInteger(SplashKit.ReadLine());
            SplashKit.WriteLine("y2: ");
            int y2 = SplashKit.ConvertToInteger(SplashKit.ReadLine());
            SplashKit.WriteLine("x3: ");
            int x3 = SplashKit.ConvertToInteger(SplashKit.ReadLine());
            SplashKit.WriteLine("y3: ");
            int y3 = SplashKit.ConvertToInteger(SplashKit.ReadLine());

            // Let user create a point
            SplashKit.WriteLine("Create a point now!");
            SplashKit.WriteLine("x for point: ");
            int px1 = SplashKit.ConvertToInteger(SplashKit.ReadLine());
            SplashKit.WriteLine("y for point: ");
            int py1 = SplashKit.ConvertToInteger(SplashKit.ReadLine());

            SplashKit.OpenWindow("Point In Triangle", 800, 600);
            SplashKit.ClearScreen();

            // Create the triangle base on the data given by user
            Triangle A = SplashKit.TriangleFrom(x1, y1, x2, y2, x3, y3);

            // Create the point base on the data given by user
            Point2D B = SplashKit.PointAt(px1, py1);

            // Draw the triangle
            SplashKit.DrawTriangle(SplashKit.ColorRed(), A);

            // Draw the point
            SplashKit.FillCircle(SplashKit.ColorGreen(), px1, py1, 4);

            // Detect if the point in the triangle or not
            if (SplashKit.PointInTriangle(B, A))
            {
                SplashKit.WriteLine("Point in the triangle!");
            }
            else
            {
                SplashKit.WriteLine("Point not in the triangle!");
            }

            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}

