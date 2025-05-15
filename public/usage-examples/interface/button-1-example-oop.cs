using SplashKitSDK;

namespace CreatingUserInterfaces
{
    public class Program
    {
        public static void Main()
        {
            // Open a window for the button toggle example
            SplashKit.OpenWindow("Background Color Toggle Button", 600, 400);

            Color bgColor = SplashKit.ColorWhite();
            Rectangle btnRect = SplashKit.RectangleFrom(200, 180, 200, 40);

            // Continue running until the user closes the window
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Provide visual feedback by toggling the background color when clicked
                if (SplashKit.Button("Click Me!", btnRect))
                {
                    if (bgColor == SplashKit.ColorWhite())
                    {
                        bgColor = SplashKit.ColorLightBlue();
                    }
                    else
                    {
                        bgColor = SplashKit.ColorWhite();
                    }
                }

                // Draw the current frame
                SplashKit.ClearScreen(bgColor);
                SplashKit.Button("Click Me!", btnRect);
                SplashKit.DrawInterface();
                SplashKit.RefreshScreen(60);
            }

            // Clean up and close
            SplashKit.CloseAllWindows();
        }
    }
}
