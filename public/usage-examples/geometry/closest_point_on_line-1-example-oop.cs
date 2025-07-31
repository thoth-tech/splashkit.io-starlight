using SplashKitSDK;

namespace ClosestPointOnLineExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Point of Attraction", 800, 600);

            //Declaring line and variable points
            Point2D cursorPos;
            Point2D closestPoint;
            Line line = SplashKit.LineFrom(150, 150, 500, 500);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                cursorPos = SplashKit.MousePosition();
                closestPoint = SplashKit.ClosestPointOnLine(cursorPos, line);

                //Draw the line and display results
                SplashKit.ClearScreen();
                SplashKit.DrawLine(Color.Black, line);
                SplashKit.FillCircle(Color.Red, cursorPos.X, cursorPos.Y, 5);
                SplashKit.FillCircle(Color.Blue, closestPoint.X, closestPoint.Y, 5);
                SplashKit.DrawLine(Color.Green, cursorPos, closestPoint);
                SplashKit.DrawText("Cursor Position: " + SplashKit.PointToString(cursorPos), Color.Black, 20, 40);
                SplashKit.DrawText("Closest Point on Line: " + SplashKit.PointToString(closestPoint), Color.Black, 20, 80);
                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}
