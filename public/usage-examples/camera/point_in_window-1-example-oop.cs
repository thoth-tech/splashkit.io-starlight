using SplashKitSDK;

namespace PointInWindowExample
{
    public class Program
    {
        public static void Main()
        {
            int windowWidth = 800;
            double pointX = -30;
            double movementSpeed = 2;
            Window demoWindow = SplashKit.OpenWindow("Moving Point Boundary Check", windowWidth, 500);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Move the point across both window boundaries to show both results.
                pointX += movementSpeed;
                if (pointX > windowWidth + 30)
                {
                    pointX = -30;
                }

                Point2D testPoint = SplashKit.PointAt(pointX, 300);
                bool pointIsInside = SplashKit.PointInWindow(demoWindow, testPoint);

                SplashKit.ClearScreen(SplashKit.RGBColor(24, 31, 46));
                SplashKit.DrawText("POINT IN WINDOW", SplashKit.ColorWhite(), 315, 70);
                SplashKit.DrawText("The yellow point moves through the window boundaries.", SplashKit.ColorWhite(), 225, 120);
                SplashKit.DrawText("point_in_window result:", SplashKit.ColorWhite(), 300, 185);

                if (pointIsInside)
                {
                    SplashKit.DrawText("TRUE - POINT IS INSIDE", SplashKit.ColorGreen(), 300, 225);
                    SplashKit.FillCircle(SplashKit.ColorYellow(), testPoint, 15);
                }
                else
                {
                    SplashKit.DrawText("FALSE - POINT IS OUTSIDE", SplashKit.ColorRed(), 295, 225);
                }

                SplashKit.DrawLine(SplashKit.ColorWhite(), 0, 300, windowWidth, 300);
                SplashKit.DrawText("Close the window to finish.", SplashKit.ColorWhite(), 310, 430);

                // A steady refresh rate keeps the movement easy to follow.
                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
