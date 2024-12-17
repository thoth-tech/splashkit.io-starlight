using SplashKitSDK;

namespace VectorVisualisationDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            SplashKit.OpenWindow("Vector Visualisations", 300, 300);

            // Define the outer circle
            Circle outerCircle = new Circle
            {
                Center = new Point2D { X = 150, Y = 150 },
                Radius = 75
            };

            // Define the inner point
            Point2D innerPoint = new Point2D { X = 150, Y = 150 };

            // Define the velocity vector
            Vector2D velocity = new Vector2D { X = 10, Y = 10 };
            Vector2D escape = SplashKit.VectorOutOfCircleFromPoint(innerPoint, outerCircle, velocity);

            // Create line representing the escape vector
            Line vectorLine = SplashKit.LineFrom(innerPoint, escape);

            // Clear the screen and draw shapes
            SplashKit.ClearScreen(SplashKit.ColorWhite());
            SplashKit.FillCircle(SplashKit.ColorBlack(), outerCircle);
            SplashKit.FillCircle(SplashKit.ColorYellow(), SplashKit.CircleAt(innerPoint, 3));

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
