using SplashKitSDK;

namespace WindowIsFullscreenExample
{
    public class Program
    {
        private static void DrawWindowStatus(Window wnd, string name)
        {
            // Ask this specific window, using its handle, whether it is fullscreen
            bool isFullscreen = SplashKit.WindowIsFullscreen(wnd);

            wnd.Clear(Color.White);
            wnd.DrawText(name, Color.Black, "arial", 40, 20, 30);

            if (isFullscreen)
            {
                wnd.DrawText("Fullscreen: true", Color.Black, "arial", 30, 20, 100);
            }
            else
            {
                wnd.DrawText("Fullscreen: false", Color.Black, "arial", 30, 20, 100);
            }

            wnd.DrawText("Press L or R to toggle a window", Color.DarkGray, "arial", 20, 20, 170);
            wnd.Refresh();
        }

        public static void Main()
        {
            Window leftWindow = SplashKit.OpenWindow("Left Window", 480, 280);
            Window rightWindow = SplashKit.OpenWindow("Right Window", 480, 280);

            // Place the windows side by side so both stay visible
            leftWindow.MoveTo(60, 100);
            rightWindow.MoveTo(580, 100);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Each key sends one window in or out of fullscreen
                if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    leftWindow.ToggleFullscreen();
                }

                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    rightWindow.ToggleFullscreen();
                }

                // Every window reports its own state, so the text stays visible while it fills the screen
                DrawWindowStatus(leftWindow, "Left Window");
                DrawWindowStatus(rightWindow, "Right Window");
            }

            SplashKit.CloseAllWindows();
        }
    }
}
