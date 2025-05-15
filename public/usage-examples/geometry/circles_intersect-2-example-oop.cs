using SplashKitSDK;

namespace CircleIntersectExample
{
    public class Program
    {
        public static void Main()
        {
            // Open a window for the circle-intersection demo
            SplashKit.OpenWindow("Background Change Circles", 600, 600);
            // Determine the static circle’s center and radius
            var center    = SplashKit.ScreenCenter();
            float centerX = (float)center.X;
            float centerY = (float)center.Y;
            const float radius = 80f;

            // Main loop runs until the user closes the window
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Get the moving circle’s position from the mouse
                var mp     = SplashKit.MousePosition();
                float mouseX = (float)mp.X;
                float mouseY = (float)mp.Y;

                // Toggle background on collision
                if (SplashKit.CirclesIntersect(centerX, centerY, radius, mouseX, mouseY, radius))
                {
                    SplashKit.ClearScreen(SplashKit.ColorRed());
                }
                else
                {
                    SplashKit.ClearScreen(SplashKit.ColorWhite());
                }

                // Draw the two circles
                SplashKit.FillCircle(SplashKit.ColorBlue(), centerX, centerY, radius);
                SplashKit.FillCircle(SplashKit.ColorGreen(), mouseX,  mouseY, radius);

                // Refresh at 30 FPS for smooth animation
                SplashKit.RefreshScreen(30);
            }

            // Clean up and close
            SplashKit.CloseAllWindows();
        }
    }
}
