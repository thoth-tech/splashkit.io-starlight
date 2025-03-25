using SplashKitSDK;

namespace OptionRotateBmpExample
{
    public class Program
    {
        public static void Main()
        {
            // Set the frame rate to 60 frames per second
            const int fps = 60;

            // Open a window with dimensions 800 x 600
            Window window = SplashKit.OpenWindow("Usage Example - Option Rotate Bmp", 800, 600);

            // Create a bitmap with dimensions 300 x 300
            Bitmap bmp = SplashKit.CreateBitmap("box", 300, 300);

            // Draw a red box on the bitmap
            Quad rect = SplashKit.QuadFrom(0, 0, 300, 0, 0, 300, 300, 300);
            bmp.FillQuad(Color.Red, rect);

            // Initialize a double to hold the angle of the rotated bitmap
            double angle = 0;

            // Loop until the user exits
            while (!window.CloseRequested)
            {
                // Poll for events caused by user interaction
                SplashKit.ProcessEvents();

                // Rotate the box 180 degrees every second
                angle += 360 / 2 / fps;

                // Create the draw options that will rotate the bitmap
                DrawingOptions opts = SplashKit.OptionRotateBmp(angle);

                // Clear the previous frame and set the background to black
                window.Clear(Color.Black);

                // Draw the rotated bitmap at the center of the screen
                window.DrawBitmap(bmp, 250, 150, opts);
                window.Refresh(fps);
            }

            // Clean up by freeing any memory used by the window
            window.Close();
        }
    }
}
