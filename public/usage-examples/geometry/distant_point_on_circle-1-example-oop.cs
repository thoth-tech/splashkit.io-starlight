using SplashKitSDK;

namespace DistantPointOnCircleExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Distant Point On Circle", 800, 600);

            Point2D cursorPos;
            Circle circleShape = SplashKit.CircleAt(SplashKit.PointAt(400, 200), 100);
            Point2D distantPointCoordinates;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                cursorPos = SplashKit.MousePosition();

                // Point2D variable stores the x and y coordinates of the furthest point between the circle and mouse cursor
                distantPointCoordinates = SplashKit.DistantPointOnCircle(cursorPos, circleShape);

                SplashKit.ClearScreen();
                SplashKit.DrawCircle(Color.Black, circleShape);
                SplashKit.FillCircle(Color.Red, SplashKit.CircleAt(distantPointCoordinates, 5));
                SplashKit.DrawText($"Most distant point on circle's circumference from mouse cursor is: {(int)distantPointCoordinates.X}, {(int)distantPointCoordinates.Y}", Color.Black, 100, 500);
                
                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}