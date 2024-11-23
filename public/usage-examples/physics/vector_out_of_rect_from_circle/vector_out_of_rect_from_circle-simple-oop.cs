using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace VectorVisualisationDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            OpenWindow("Vector Visualisations", 300, 300);

            // Define the outer rectangle
            Rectangle outerRectangle = new Rectangle() { X = 75, Y = 75, Width = 150, Height = 150 };

            // Define the inner circle
            Circle innerCircle = new Circle() { Center = new Point2D() { X = 150, Y = 150 }, Radius = 25 };

            // Define velocity vector
            Vector2D velocity = new Vector2D() { X = 10, Y = 10 };

            // Calculate escape vector
            Vector2D escape = VectorOutOfRectFromCircle(innerCircle, outerRectangle, velocity);

            // Create line representing the escape vector
            Line vectorLine = LineFrom(innerCircle.Center, escape);

            // Clear the screen and draw shapes
            ClearScreen();
            FillRectangle(ColorBlack(), outerRectangle);
            FillCircle(ColorYellow(), innerCircle);

            // Draw the escape vector line
            DrawLine(ColorRed(), vectorLine);

            // Refresh the screen
            RefreshScreen();

            // Wait and close the window
            Delay(4000);
            CloseAllWindows();
        }
    }
}
