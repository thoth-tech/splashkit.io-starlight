using SplashKitSDK;

namespace ClosestPoint
{
    public class Program 
    {
        public static void Main()
        {
            // Prompt for x and y value 
            SplashKit.Write("Enter x point: ");
            int x = SplashKit.ConvertToInteger(SplashKit.ReadLine());
            SplashKit.Write("Enter y point: ");
            int y = SplashKit.ConvertToInteger(SplashKit.ReadLine());

            Window wnd = SplashKit.OpenWindow("Closest Point", 600, 600);
            SplashKit.ClearScreen();

            // Set circle point to center of screen and draw to screen
            Point2D circle_pnt = new Point2D() {X = 300, Y = 300};
            Circle circle = SplashKit.CircleAt(circle_pnt, 100);
            SplashKit.DrawCircle(Color.Black, circle);

            SplashKit.RefreshScreen();

             // Initialize the input points as a 2D point
            Point2D point = new Point2D() {X = x, Y = y};

            // Get closest point to the point on circle
            Point2D close_point = SplashKit.ClosestPointOnCircle(point, circle);

            // Draw circle to indicate point
            SplashKit.FillCircleOnWindow(wnd, Color.Red, close_point.X, close_point.Y, 5);

            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}