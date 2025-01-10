using SplashKitSDK;

namespace PointIntriangle
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Point In Triangle", 800, 600);
            SplashKit.ClearScreen();

            // Create a triangle A
            Triangle A = SplashKit.TriangleFrom(700, 200, 500, 1, 200, 500);

            // Create a point 2d name mounse point
            Point2D MousePoint;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Set mouse point to the position of mouse
                MousePoint = SplashKit.MousePosition();

                // When mouse inside the triangle show text "point in the triangle!" and the color of the triangle change to red
                if (SplashKit.PointInTriangle(MousePoint, A))
                {
                    SplashKit.ClearScreen();
                    SplashKit.DrawTriangle(SplashKit.ColorRed(), A);
                    string text = "Point in the triangle!";
                    SplashKit.DrawText(text, SplashKit.ColorRed(), 100, 100);
                    SplashKit.RefreshScreen();
                }
                // When mouse do not inside the triangle show text "point not in the triangle!" and the color of the triangle change to green
                else
                {
                    SplashKit.ClearScreen();
                    SplashKit.DrawTriangle(SplashKit.ColorGreen(), A);
                    string text = "Point not in the triangle!";
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

