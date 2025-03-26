using SplashKitSDK;

namespace OptionScaleBmpExample
{
    public class Program
    {
        public static void Main()
        {
            // Set frame rate to 60 frames per second
            const int fps = 60;

            // Create a window with dimensions 800 x 600
            Window window = SplashKit.OpenWindow("Usage Example - Option Scale Bitmap", 800, 600);

            // Create a bitmap called 'ring' with dimensions 600 x 600
            Bitmap bmp = SplashKit.CreateBitmap("ring", 600, 600);

            // Paint the bitmap background black
            bmp.Clear(Color.Black);

            // Draw a ring on the bitmap
            bmp.FillCircle(Color.White, 300, 300, 300);
            bmp.FillCircle(Color.Black, 300, 300, 200);

            // Initialize the time to 0
            double time = 0;

            // Loop until the user closes the window
            while (!window.CloseRequested)
            {
                // Poll for user interactions
                SplashKit.ProcessEvents();

                // Increment the time by the duration of a frame
                time += 1.0 / fps;

                // Calculate the scale factor by squaring the time
                double scaleFactor = time * time;

                // If the bitmap is over 2.5 times its initial size, then reset the time
                if (scaleFactor > 2.5) time = 0;

                // Create the draw options that will scale the bitmap
                DrawingOptions opts = SplashKit.OptionScaleBmp(scaleFactor, scaleFactor);

                // Draw the scaled bitmap onto the window and refresh
                window.Clear(Color.Black);
                window.DrawBitmap(bmp, 100, 0, opts);
                window.Refresh(fps);
            }

            // Clean up any memory or resources being used by the window
            window.Close();
        }
    }
}
