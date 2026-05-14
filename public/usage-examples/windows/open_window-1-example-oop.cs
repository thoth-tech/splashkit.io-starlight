using SplashKitSDK;

namespace OpenWindowExample
{
    public class Program
    {
        public static void Main()
        {
            // Open a new window
            Window wind = SplashKit.OpenWindow("Simple Welcome Screen", 800, 600);

            // Keep the program running until the user closes the window
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Draw content on the screen
                SplashKit.ClearWindow(wind, SplashKit.ColorSkyBlue());
                SplashKit.FillRectangle(SplashKit.ColorWhite(), 220, 230, 360, 120);
                SplashKit.DrawText("Welcome to SplashKit!", SplashKit.ColorBlack(), 290, 270);
                SplashKit.DrawText("This window was opened using OpenWindow.", SplashKit.ColorBlack(), 245, 305);

                SplashKit.RefreshWindow(wind);
            }

            // Close all open windows
            SplashKit.CloseAllWindows();
        }
    }
}