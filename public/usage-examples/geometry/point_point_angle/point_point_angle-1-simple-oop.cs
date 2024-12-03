using SplashKitSDK;

namespace PointPointAngle
{
    public class Program
    {
        public static void Main()
        {
        SplashKit.OpenWindow("Point Point Angle", 800, 600);
        SplashKit.ClearScreen();

        // Draw the circle at the origin point
        SplashKit.FillCircle(Color.Red, 400, 300, 2);

        // Define the origin point
        Point2D originPoint = SplashKit.PointAt(400, 300);

        SplashKit.RefreshScreen();

        while (!SplashKit.QuitRequested())
        {
            // Get the current mouse position
            Point2D mouse = SplashKit.MousePosition();

            // Calculate the angle between the origin point and the mouse position
            float angle = SplashKit.PointPointAngle(originPoint, mouse);

            // Print angle 
            SplashKit.WriteLine(angle);

            SplashKit.Delay(100); 
        }

        SplashKit.CloseAllWindows();
        }
    }
}

