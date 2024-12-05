using SplashKitSDK;

namespace PointAt
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Point At", 800, 600);
            SplashKit.ClearScreen();

            for (int i = 0; i < 30; i++)
            {
                int x1 = SplashKit.Rnd(800);
                int y1 = SplashKit.Rnd(600);

                // Create a point at position (x1,y1)
                Point2D point = SplashKit.PointAt(x1, y1);

                Color randomColor = SplashKit.RGBColor(
                    SplashKit.Rnd(255), SplashKit.Rnd(255), SplashKit.Rnd(255)
                );

                // Create graphs at the point
                SplashKit.FillCircle(randomColor, point.X, point.Y, 4);
                SplashKit.FillCircle(randomColor, point.X + 20, point.Y, 4);
                SplashKit.FillRectangle(randomColor, point.X + 10, point.Y + 10, 10, 10);
            }

            // Create a point at middle of the screen
            Point2D pointMiddle = SplashKit.PointAt(400, 300);

            // Draw the point
            SplashKit.FillCircle(Color.Red, pointMiddle.X, pointMiddle.Y, 4);
            SplashKit.DrawText("Center Point", Color.Black, pointMiddle.X - 20, pointMiddle.Y - 20);

            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}

