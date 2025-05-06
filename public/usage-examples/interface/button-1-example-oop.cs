using SplashKitSDK;

namespace CreatingUserInterfaces
{
    public class Program
    {
        public static void Main()
        {
            // Open the window
            SplashKit.OpenWindow("Button Toggle", 600, 400);

            Color bgColor = SplashKit.ColorWhite();
            Rectangle btnRect = SplashKit.RectangleFrom(200, 180, 200, 40);

            // Main loop
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // If the button is clicked, toggle the background color
                if (SplashKit.Button("Click Me!", btnRect))
                {
                    bgColor = (bgColor == SplashKit.ColorWhite()) ? SplashKit.ColorLightBlue() : SplashKit.ColorWhite();
                }

                // Draw background and interface
                SplashKit.ClearScreen(bgColor);
                SplashKit.Button("Click Me!", btnRect);
                SplashKit.DrawInterface();
                SplashKit.RefreshScreen(60);
            }

            // Close all open windows
            SplashKit.CloseAllWindows();
        }
    }
}