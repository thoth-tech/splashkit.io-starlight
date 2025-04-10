using SplashKitSDK;

namespace CircleIntersectsLine
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Circle Intersects Line", 800, 600);

            //Define a circle
            Circle circle = SplashKit.CircleAt(400, 300, 100);

            //Define a line
            Point2D startPoint = new Point2D() { X = 100, Y = 100 };
            Point2D endPoint = new Point2D() { X = 700, Y = 500 };

            //Draw the line
            Line line = SplashKit.LineFrom(startPoint, endPoint);
            SplashKit.DrawLine(Color.Blue, line);

            //Draw the circle
            SplashKit.DrawCircle(Color.Red, circle);

            //Check for intersection
            bool intersect = SplashKit.LineIntersectsCircle(line, circle);

            //Display Results
            SplashKit.DrawText("Line and circle intersect: " + (intersect ? "Yes" : "No"), Color.Black, 400, 100);

            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}
