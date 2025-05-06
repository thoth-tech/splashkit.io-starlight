using SplashKitSDK;

namespace ClosestPointOnLineFromCircleExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Closest Point On Line From Circle", 800, 600);

            Point2D cursorPos;
            Point2D closestPointCoordinates;
            Point2D lineStart = SplashKit.PointAt(300, 400);
            Circle circleShape = SplashKit.CircleAt(SplashKit.PointAt(250, 150), 100);
            Line lineShape;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                cursorPos = SplashKit.MousePosition();
                lineShape = SplashKit.LineFrom(lineStart, cursorPos);

                // Point2D variable stores the x and y coordinates of the closest point between the circle and line
                closestPointCoordinates = SplashKit.ClosestPointOnLineFromCircle(circleShape, lineShape);

                SplashKit.ClearScreen();
                SplashKit.DrawCircle(Color.Black, circleShape);
                SplashKit.DrawLine(Color.Black, lineShape);
                SplashKit.FillCircle(Color.Red, SplashKit.CircleAt(closestPointCoordinates, 5));

                SplashKit.DrawText("Position of closest point on line from circle: " + SplashKit.PointToString(closestPointCoordinates), Color.Black, 110, 500);
                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}