using SplashKitSDK;

namespace PointLineDistanceExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Distance from Mouse to Line", 800, 600);

            // Use one fixed line and let the mouse act as the test point
            Line demoLine = SplashKit.LineFrom(150, 300, 650, 300);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Measure how far the mouse point is from the line
                Point2D pt = SplashKit.MousePosition();
                float distance = SplashKit.PointLineDistance(pt, demoLine);

                SplashKit.ClearScreen(Color.White);

                // Draw the line, the point, and the measured distance
                SplashKit.DrawLine(Color.Black, demoLine);
                SplashKit.FillCircle(Color.Red, pt.X, pt.Y, 6);

                SplashKit.DrawText("Move the mouse to change the point.", Color.Black, 20, 20);
                SplashKit.DrawText("Distance from point to line: " + distance.ToString(), Color.Blue, 20, 50);

                SplashKit.RefreshScreen(60);
            }
        }
    }
}