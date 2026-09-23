using SplashKitSDK;

namespace WidestPointsExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Widest Points on a Circle", 800, 600);

            Circle demoCircle = SplashKit.CircleAt(400, 300, 120);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Use the mouse position to define the direction vector
                Point2D center = SplashKit.CenterPoint(demoCircle);
                Point2D mousePt = SplashKit.MousePosition();
                Vector2D along = SplashKit.VectorPointToPoint(center, mousePt);

                // Calculate the two points on the circle along the vector
                Point2D pt1 = new Point2D();
                Point2D pt2 = new Point2D();
                SplashKit.WidestPoints(demoCircle, along, ref pt1, ref pt2);

                SplashKit.ClearScreen(Color.White);

                // Draw the circle and the direction being tested
                SplashKit.DrawCircle(Color.Black, demoCircle);
                SplashKit.DrawLine(Color.Gray, center, mousePt);

                // Draw the widest points returned by the function
                SplashKit.DrawLine(Color.Blue, pt1, pt2);
                SplashKit.FillCircle(Color.Red, pt1.X, pt1.Y, 6);
                SplashKit.FillCircle(Color.Red, pt2.X, pt2.Y, 6);

                SplashKit.DrawText("Move the mouse to change the vector.", Color.Black, 20, 20);
                SplashKit.DrawText("The red points are the widest points on the circle.", Color.Blue, 20, 50);

                SplashKit.RefreshScreen(60);
            }
        }
    }
}