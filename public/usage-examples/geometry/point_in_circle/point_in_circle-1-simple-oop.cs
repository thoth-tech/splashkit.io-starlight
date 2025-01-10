using SplashKitSDK;

namespace PointInCircle
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Point In Circle", 800, 600);
            SplashKit.ClearScreen();

            // Create a circle A
            Circle A = SplashKit.CircleAt(400, 300, 100);

            // Create a point 2d name mounse point
            Point2D MousePoint;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Set mouse point to the position of mouse
                MousePoint = SplashKit.MousePosition();

                // When mouse inside the circle show text "point in the circle!" and the color of the circle change to red
                if (SplashKit.PointInCircle(MousePoint, A))
                {
                    SplashKit.ClearScreen();
                    SplashKit.DrawCircle(SplashKit.ColorRed(), A);
                    string text = "Point in the Circle!";
                    SplashKit.DrawText(text, SplashKit.ColorRed(), 100, 100);
                    SplashKit.RefreshScreen();
                }
                // When mouse do not inside the circle show text "point not in the circle!" and the color of the circle change to green
                else
                {
                    SplashKit.ClearScreen();
                    SplashKit.DrawCircle(SplashKit.ColorGreen(), A);
                    string text = "Point not in the Circle!";
                    SplashKit.DrawText(text, SplashKit.ColorRed(), 100, 100);
                    SplashKit.RefreshScreen();
                }
            }

            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}