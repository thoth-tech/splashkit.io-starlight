using SplashKitSDK;

namespace CurrentWindowToggleFullscreenExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Presentation Mode", 800, 450);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Toggling means the same key can both enter and leave fullscreen
                if (SplashKit.KeyTyped(KeyCode.FKey))
                {
                    SplashKit.CurrentWindowToggleFullscreen();
                }

                // Draw for the new state so the screen shows which mode the window is in
                if (SplashKit.CurrentWindowIsFullscreen())
                {
                    SplashKit.ClearScreen(Color.Black);
                    SplashKit.DrawText("Fullscreen mode", Color.White, "arial", 48, 40, 60);
                    SplashKit.DrawText("Press F to leave fullscreen", Color.LightGray, "arial", 28, 40, 150);
                }
                else
                {
                    SplashKit.ClearScreen(Color.White);
                    SplashKit.DrawText("Windowed mode", Color.Black, "arial", 48, 40, 60);
                    SplashKit.DrawText("Press F to enter fullscreen", Color.DarkGray, "arial", 28, 40, 150);
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
