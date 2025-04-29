using SplashKitSDK;

namespace DrawPixelOnWindowExample
{
    public class Program
    {
        public static void Main()
        {
            // Declare constants
            const int FPS = 60;     // Set frame rate to 60 frames per second

            const int WINDOW_WIDTH = 800;
            const int WINDOW_HEIGHT = 600;

            Display display = SplashKit.DisplayDetails(0);

            int WINDOW_X_POS = (display.Width - 2 * WINDOW_WIDTH) / 2;
            int WINDOW_Y_POS = (display.Height - WINDOW_HEIGHT) / 2;

            const double MAX_RADIUS = WINDOW_HEIGHT * 3.0 / 8;

            // Declare variables
            double angle = 0.0;
            double radius = 0.0;

            // Open two windows with black backgrounds and position them side by side at center screen
            Window windowLeft = SplashKit.OpenWindow("Left Window - Pink Spiral", WINDOW_WIDTH, WINDOW_HEIGHT);
            Window windowRight = SplashKit.OpenWindow("Right Window - Blue Spiral", WINDOW_WIDTH, WINDOW_HEIGHT);

            windowLeft.Clear(Color.Black);
            windowRight.Clear(Color.Black);

            windowLeft.MoveTo(WINDOW_X_POS, WINDOW_Y_POS);
            windowRight.MoveTo(WINDOW_X_POS + WINDOW_WIDTH, WINDOW_Y_POS);

            while (!windowLeft.CloseRequested && !windowRight.CloseRequested)
            {
                SplashKit.ProcessEvents();

                // Stop drawing when max radius is exceeded
                if (radius > MAX_RADIUS)
                {
                    continue;
                }

                // Increment the radius and angle of the next pixel, and calculate the x-y coordinates
                radius += MAX_RADIUS / FPS / 60;
                angle += 360.0 / FPS / 15;

                double x = WINDOW_WIDTH / 2 + radius * SplashKit.Cosine((float)angle);
                double y = WINDOW_HEIGHT / 2 + radius * SplashKit.Sine((float)angle);

                // Draw the pixel on each window and refresh
                // NOTE: The Window class currently doesn't have a DrawPixel method
                SplashKit.DrawPixelOnWindow(windowLeft, Color.HotPink, x, y);
                SplashKit.DrawPixelOnWindow(windowRight, Color.Cyan, x, y);
                SplashKit.RefreshScreen(FPS);
            }

            // Clean up
            SplashKit.CloseAllWindows();
        }
    }
}