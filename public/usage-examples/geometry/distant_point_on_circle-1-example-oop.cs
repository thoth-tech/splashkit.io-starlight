using SplashKitSDK;

namespace DistantPointOnCircleExample
{
    public class Program
    {
        public static void Main()
        {
            // Create the circle and window used to demonstrate the distant point
            Circle demoCircle = SplashKit.CircleAt(400, 300, 120);
            SplashKit.OpenWindow("Opposite Point to Mouse on Circle", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Use the mouse position as the point being tested
                Point2D testPoint = SplashKit.MousePosition();

                // Find the point on the circle furthest from the mouse
                Point2D distantPoint = SplashKit.DistantPointOnCircle(testPoint, demoCircle);

                SplashKit.ClearScreen(Color.White);

                // Draw the circle and helper lines to show the relationship clearly
                SplashKit.DrawCircle(Color.Black, demoCircle);
                SplashKit.DrawLine(Color.Gray, SplashKit.CenterPoint(demoCircle), testPoint);
                SplashKit.DrawLine(Color.Green, SplashKit.CenterPoint(demoCircle), distantPoint);

                // Highlight the mouse point and the distant point
                SplashKit.FillCircle(Color.Red, testPoint.X, testPoint.Y, 6);
                SplashKit.FillCircle(Color.Green, distantPoint.X, distantPoint.Y, 8);
                SplashKit.FillCircle(Color.Blue, SplashKit.CenterPoint(demoCircle).X, SplashKit.CenterPoint(demoCircle).Y, 5);

                // Display instructions and labels on the window
                SplashKit.DrawText("Move the mouse to change the test point", Color.Black, 20, 20);
                SplashKit.DrawText("Red = test point", Color.Red, 20, 50);
                SplashKit.DrawText("Green = distant point on circle", Color.Green, 20, 80);
                SplashKit.DrawText("Blue = circle center", Color.Blue, 20, 110);

                SplashKit.RefreshScreen(60);
            }
        }
    }
}