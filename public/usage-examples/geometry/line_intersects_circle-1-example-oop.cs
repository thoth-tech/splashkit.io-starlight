using SplashKitSDK;

namespace LineIntersectsCircleExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Line Intersects Circle", 800, 600);

            Circle demoCircle = SplashKit.CircleAt(400, 300, 120);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Create a line from a fixed point to the mouse position
                Point2D startPt = SplashKit.PointAt(100, 300);
                Point2D endPt = SplashKit.MousePosition();

                Line demoLine = SplashKit.LineFrom(startPt, endPt);

                // Check if the line intersects the circle
                bool intersects = SplashKit.LineIntersectsCircle(demoLine, demoCircle);

                SplashKit.ClearScreen(Color.White);

                // Draw the circle
                SplashKit.DrawCircle(Color.Black, demoCircle);

                // Draw the line based on intersection result
                if (intersects)
                {
                    SplashKit.DrawLine(Color.Green, demoLine);
                    SplashKit.DrawText("The line intersects the circle.", Color.Green, 20, 20);
                }
                else
                {
                    SplashKit.DrawLine(Color.Red, demoLine);
                    SplashKit.DrawText("The line does not intersect the circle.", Color.Red, 20, 20);
                }

                SplashKit.RefreshScreen(60);
            }
        }
    }
}