using SplashKitSDK;

namespace DistantPointOnCircle
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Distant Point On Circle", 800, 600);

            Point2D cursor_pos;
            Circle circle_shape = SplashKit.CircleAt(SplashKit.PointAt(400, 200), 100);
            Point2D distant_point_coordinates;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                cursor_pos = SplashKit.MousePosition();

                // Point2D variable stores the x and y coordinates of the furthest point between the circle and mouse cursor
                distant_point_coordinates = SplashKit.DistantPointOnCircle(cursor_pos, circle_shape);

                SplashKit.ClearScreen();
                SplashKit.DrawCircle(SplashKit.ColorBlack(), circle_shape);
                SplashKit.FillCircle(SplashKit.ColorRed(), SplashKit.CircleAt(distant_point_coordinates, 5));

                SplashKit.DrawText("Most distant point on circle's circumference from mouse cursor is: " + SplashKit.PointToString(distant_point_coordinates), SplashKit.ColorBlack(), 35, 500);
                SplashKit.RefreshScreen();
            }
            window.Close();
        }
    }
}