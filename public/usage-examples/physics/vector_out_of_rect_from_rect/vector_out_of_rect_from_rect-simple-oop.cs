using SplashKitSDK;

namespace VectorVisualisationDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            SplashKit.OpenWindow("Vector Visualisations", 300, 300);

            // Define the inner rectangle
            Rectangle innerRectangle = new Rectangle() { X = 125, Y = 125, Width = 50, Height = 50 };

            // Define the outer rectangle
            Rectangle outerRectangle = new Rectangle() { X = 75, Y = 75, Width = 150, Height = 150 };

            // Define velocity vector
            Vector2D velocity = new Vector2D() { X = 10, Y = 10 };

            // Calculate escape vector
            Vector2D escape = SplashKit.VectorOutOfRectFromRect(innerRectangle, outerRectangle, velocity);

            // Define the origin point
            Point2D origin = new Point2D() { X = 150, Y = 150 };

            // Create line representing the escape vector
            Line vectorLine = SplashKit.LineFrom(origin, escape);

            // Clear the screen and draw shapes
            SplashKit.ClearScreen();
            SplashKit.FillRectangle(SplashKit.ColorRed(), outerRectangle);
            SplashKit.FillRectangle(SplashKit.ColorBlack(), innerRectangle);

            // Draw the escape vector line
            SplashKit.DrawLine(SplashKit.ColorBlue(), vectorLine);

            // Refresh the screen
            SplashKit.RefreshScreen();

            // Wait and close the window
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}
