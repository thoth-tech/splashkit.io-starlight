using SplashKitSDK;

namespace LineIntersectsCircleExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Interaction of Line and Circle", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                //Defining a line and circle
                Point2D cursorPos = SplashKit.MousePosition();
                Line line = SplashKit.LineFrom(SplashKit.PointAt(150, 100), cursorPos);
                Circle circle = SplashKit.CircleAt(400, 300, 100);

                SplashKit.ClearScreen();

                //Drawing the line and circle
                SplashKit.DrawLine(Color.Blue, line);
                SplashKit.DrawCircle(Color.Black, circle);

                //Check for intersection and display the results
                if (SplashKit.LineIntersectsCircle(line, circle))
                {
                    SplashKit.DrawText("Line and Circle intersect", Color.Green, 400, 100);
                }
                else
                {
                    SplashKit.DrawText("Line and Circle do not intersect", Color.Red, 400, 100);
                }

                SplashKit.RefreshScreen();
            }

            SplashKit.CloseAllWindows();
        }
    }
}
