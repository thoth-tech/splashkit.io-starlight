using SplashKitSDK;

namespace PointInCircleExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Circular Toggle Button", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                //Declaring the variables
                Color circleColor;
                Point2D cursorPos = SplashKit.MousePosition();
                Circle circle = SplashKit.CircleAt(400, 300, 80);

                SplashKit.ClearScreen();

                if (SplashKit.PointInCircle(cursorPos, circle))
                {
                    circleColor = Color.Green;
                    SplashKit.DrawText("Point is in the circle", Color.Green, 300, 100);
                }
                else
                {
                    circleColor = Color.BrightGreen;
                    SplashKit.DrawText("Point is not in the circle", Color.Red, 300, 100);
                }

                SplashKit.FillCircle(circleColor, circle);
                SplashKit.DrawText("Button", Color.Black, 375, 300);

                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}
