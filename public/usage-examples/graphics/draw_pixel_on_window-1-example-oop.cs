using SplashKitSDK;

namespace DrawPixelOnWindowExample
{
    public class Program
    {
        public static void Main()
        {
            // Sets the refresh rate at 60 frames per second
            const int fps = 60;

            const int width = 800;
            const int height = 600;

            // Create a window and make the background black
            Window window = SplashKit.OpenWindow("Usage Example - Draw Pixel On Window", width, height);
            window.Clear(Color.Black);

            // Variables for the angle and radius of the spiral at any given time
            double angle = 0.0;
            double radius = 0.0;

            const double max_radius = width / 2;
            Point2D center = SplashKit.PointAt(width / 2, height / 2);

            while (!window.CloseRequested)
            {
                // Poll for user interaction
                SplashKit.ProcessEvents();
                
                // Stop drawing spiral once the width of the window is exceeded
                if (radius > max_radius) continue;
                
                // Increment spiral radius so it will reach window width in 30 seconds
                radius += max_radius / fps / 30;
                
                // Increment spiral angle so it will complete a cycle every 5 seconds
                angle += 360.0 / fps / 5;
                
                // Calculate the x and y coordinates of the pixel to be drawn
                double x = center.X + radius * SplashKit.Cosine((float)angle);
                double y = center.Y + radius * SplashKit.Sine((float)angle);

                // Draws the next pixel of the spiral on the window
                SplashKit.DrawPixelOnWindow(window, Color.Yellow, x, y);
                window.Refresh(fps);
            }

            // Clean up any resources or memory used by the window
            window.Close();
        }
    }
}