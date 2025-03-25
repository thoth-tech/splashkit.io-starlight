using SplashKitSDK;

namespace LineFromExample
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
            Vector2D vec_up = new Vector2D{X = 0.0, Y = -100.0};
            Vector2D vec_right = new Vector2D{X = 100.0, Y = 0.0};

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                // Draw a red line with the up vector as offset
                SplashKit.DrawLine(Color.Red, SplashKit.LineFrom(start, vec_up));
                // Draw a blue line with the right vector as offset
                SplashKit.DrawLine(Color.Blue, SplashKit.LineFrom(start, vec_right));
                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}
