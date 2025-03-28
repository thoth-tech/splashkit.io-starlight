using SplashKitSDK;

namespace FillEllipseOnWindow
{
    public class Program
    {
        public static void Main()
        {
            // Open a new window
            Window window = SplashKit.OpenWindow("Ellipse Painter", 800, 600);
            SplashKit.ClearScreen();

            // While user doesn't request to quit window
            while (!SplashKit.WindowCloseRequested(window))
            {
                SplashKit.ProcessEvents();
                SplashKit.DrawText("Press on the C key to clear screen", Color.Black, 5, 10);

                // If mouse clicked or held down get mouse position
                if (SplashKit.MouseClicked(MouseButton.LeftButton) || SplashKit.MouseDown(MouseButton.LeftButton)) 
                {
                    Point2D pos = SplashKit.MousePosition();

                    // Fill ellipse in the position with random color
                    SplashKit.FillEllipseOnWindow(window, SplashKit.RandomColor(), pos.X, pos.Y, 100, 50);
                }

                // Clear screen if C key is pressed 
                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    SplashKit.ClearScreen();
                }

                // Close all windows
                SplashKit.RefreshScreen(60);
            }
        }
    }
}