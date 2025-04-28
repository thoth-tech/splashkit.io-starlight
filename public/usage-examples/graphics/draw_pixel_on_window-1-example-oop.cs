using SplashKitSDK;

namespace DrawPixelOnWindowExample
{
    public class Program
    {
        public static void Main()
        {
            // Access the first display
            Display display = SplashKit.DisplayDetails(0);

            // Set the refresh rate to 60 frames per second
            const int fps = 60;

            const int windowWidth = 800;
            const int windowHeight = 600;

            // Calculate the position of the first window
            int windowPositionX = (display.Width - 2 * windowWidth) / 2;
            int windowPositionY = (display.Height - windowHeight) / 2;

            // Open two windows with black backgrounds
            Window windowOne = SplashKit.OpenWindow("Window 1 - Draw Pixel On Window", windowWidth, windowHeight);
            Window windowTwo = SplashKit.OpenWindow("Window 2 - Draw Pixel On Window", windowWidth, windowHeight);
            windowOne.Clear(Color.Black);
            windowTwo.Clear(Color.Black);

            // Position the windows side by side in the middle of the display
            windowOne.MoveTo(windowPositionX, windowPositionY);
            windowTwo.MoveTo(windowPositionX + windowWidth, windowPositionY);

            // Store the angle and radius of the spiral at any given time
            double angle = 0.0;
            double radius = 0.0;

            const double maxRadius = windowWidth / 2;

            // Coordinates for the center of the spiral
            Point2D center = SplashKit.PointAt(windowWidth / 2, windowHeight / 2);

            while (!windowOne.CloseRequested && !windowTwo.CloseRequested)
            {
                // Poll for user interaction
                SplashKit.ProcessEvents();

                // Stop drawing spiral once the width of the window is exceeded
                if (radius > maxRadius) continue;

                // Increment spiral radius so it will reach window width in 30 seconds
                radius += maxRadius / fps / 30;

                // Increment spiral angle so it will complete a revolution every 5 seconds
                angle += 360.0 / fps / 5;

                // Calculate the x and y coordinates of the pixel to be drawn
                double x = center.X + radius * SplashKit.Cosine((float)angle);
                double y = center.Y + radius * SplashKit.Sine((float)angle);

                // Draw the next pixel of the spiral on both windows
                // NOTE: The Window class doesn't currently have a method for DrawPixelOnWindow
                SplashKit.DrawPixelOnWindow(windowOne, Color.Yellow, x, y);
                SplashKit.DrawPixelOnWindow(windowTwo, Color.Red, x, y);

                SplashKit.RefreshScreen(fps);
            }

            // Clean up any resources or memory used by the windows
            windowOne.Close();
            windowTwo.Close();
        }
    }
}