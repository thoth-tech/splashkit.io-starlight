using SplashKitSDK;

namespace PointPointAngleExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Point Point Angle", 800, 600);
            window.Clear(Color.White);

            // Draw the circle at the origin point
            SplashKit.FillCircle(Color.Red, 400, 300, 2);

            // Define the origin point
            Point2D originPoint = SplashKit.PointAt(400, 300);

            window.Refresh();

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

            window.Close();
        }
    }
}

