using SplashKitSDK;

namespace LineFromStartWithOffsetExample
{
    public class Program
    {
        public static void Main()
        {
            // Open a 300x300 window
            Window window = SplashKit.OpenWindow("Vector Offset Lines", 300, 300);
            // Use the center of the window as the start point for lines
            Point2D start = SplashKit.PointAt(150, 150);
            // Create vectors for up and right
            Vector2D vecUp = SplashKit.VectorTo(0.0, -100.0);
            Vector2D vecRight = SplashKit.VectorTo(100.0, 0.0);

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                // Draw a red line with the up vector as offset
                SplashKit.DrawLine(Color.Red, SplashKit.LineFrom(start, vecUp));
                // Draw a blue line with the right vector as offset
                SplashKit.DrawLine(Color.Blue, SplashKit.LineFrom(start, vecRight));
                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}
