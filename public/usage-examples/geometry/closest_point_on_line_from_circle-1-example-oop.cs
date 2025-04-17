using SplashKitSDK;

namespace ClosestPointOnLineFromCircle
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Closest Point On Line From Circle", 800, 600);

            Point2D cursor_pos;
            Circle circle_shape = SplashKit.CircleAt(SplashKit.PointAt(250, 150), 100);
            Line line_shape;
            Point2D closest_point_coordinates;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                cursor_pos = SplashKit.MousePosition();
                line_shape = SplashKit.LineFrom(SplashKit.PointAt(300, 400), cursor_pos);

                // Point2D variable stores the x and y coordinates of the closest point between the circle and line
                closest_point_coordinates = SplashKit.ClosestPointOnLineFromCircle(circle_shape, line_shape);

                SplashKit.ClearScreen();
                SplashKit.DrawCircle(SplashKit.ColorBlack(), circle_shape);
                SplashKit.DrawLine(SplashKit.ColorBlack(), line_shape);
                SplashKit.FillCircle(SplashKit.ColorRed(), SplashKit.CircleAt(closest_point_coordinates, 5));

                SplashKit.DrawText("Position of closest point on line from circle: " + SplashKit.PointToString(closest_point_coordinates), SplashKit.ColorBlack(), 110, 500);
                SplashKit.RefreshScreen();
            }
            window.Close();
        }
    }
}