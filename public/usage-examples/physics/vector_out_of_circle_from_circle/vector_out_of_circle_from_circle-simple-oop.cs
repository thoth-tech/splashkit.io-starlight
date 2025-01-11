using SplashKitSDK;

namespace VectorVisualisationDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            SplashKit.OpenWindow("Vector Visualisations", 300, 300);

            // Define outer and inner circles
            Circle outerCircle = new Circle() { Center = new Point2D() { X = 150, Y = 150 }, Radius = 75 };
            Circle innerCircle = new Circle() { Center = new Point2D() { X = 150, Y = 150 }, Radius = 25 };

            // Define velocity vector
            Vector2D velocity = new Vector2D() { X = 10, Y = 10 };

            // Calculate escape vector
            Vector2D escape = SplashKit.VectorOutOfCircleFromCircle(innerCircle, outerCircle, velocity);

            // Create line representing the escape vector
            Line vectorLine = SplashKit.LineFrom(innerCircle.Center, escape);

            // Clear the screen and draw shapes
            SplashKit.ClearScreen();
            SplashKit.FillCircle(SplashKit.ColorBlack(), outerCircle);
            SplashKit.FillCircle(SplashKit.ColorYellow(), innerCircle);

            // Draw the escape vector line
            SplashKit.DrawLine(SplashKit.ColorRed(), vectorLine);

            // Refresh the screen
            SplashKit.RefreshScreen();

            // Wait and close the window
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}
