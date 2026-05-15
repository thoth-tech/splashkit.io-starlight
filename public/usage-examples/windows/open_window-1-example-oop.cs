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
                wind.Clear(SplashKit.ColorSkyBlue());
                wind.FillRectangle(SplashKit.ColorWhite(), 220, 230, 360, 120);
                wind.DrawText("Welcome to SplashKit!", SplashKit.ColorBlack(), 290, 270);
                wind.DrawText("This window was opened using OpenWindow.", SplashKit.ColorBlack(), 245, 305);

                wind.Refresh();
            }

            // Close all open windows
            SplashKit.CloseAllWindows();
        }
    }
}
