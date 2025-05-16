using SplashKitSDK;

namespace CreatingUserInterfaces
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Background Color Toggle Button", 600, 400);

            // Define the background color and button rectangle
            Color bgColor = SplashKit.ColorWhite();
            Rectangle btnRect = SplashKit.RectangleFrom(200, 180, 200, 40);

            // Continue running until the user closes the window
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // If the button is clicked, toggle the background color
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

                // Clear screen and draw interface
                SplashKit.ClearScreen(bgColor);
                SplashKit.Button("Click Me!", btnRect);
                SplashKit.DrawInterface();
                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
