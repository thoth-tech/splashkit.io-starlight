using SplashKitSDK;

namespace LineNormalExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Line Normal", 800, 600);
            
            Line userLine;
            Line xAxisLine;
            Line yAxisLine;
            Point2D cursorPos;
            Vector2D vector;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                cursorPos = SplashKit.MousePosition();
                userLine = SplashKit.LineFrom(SplashKit.PointAt(400, 350), cursorPos);

                xAxisLine = SplashKit.LineFrom(SplashKit.PointAt(cursorPos.X, 350), SplashKit.PointAt(400, 350));
                yAxisLine = SplashKit.LineFrom(SplashKit.PointAt(400, cursorPos.Y), SplashKit.PointAt(400, 350));

                // The line normal of the desired line is stored under the vector 2d variable
                vector = SplashKit.LineNormal(userLine);

                SplashKit.ClearScreen();
                SplashKit.DrawLine(Color.Black, userLine);
                SplashKit.DrawLine(Color.Red, xAxisLine);
                SplashKit.DrawLine(Color.Red, yAxisLine);
                SplashKit.DrawText("The black line's normal is: " + vector.X.ToString() + "," + vector.Y.ToString(), Color.Black, 60, 500);

                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}