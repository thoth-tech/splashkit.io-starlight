using SplashKitSDK;

namespace CurrentWindowIsFullscreenExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Fullscreen Checker", 800, 450);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Give the player a way to change the state that we are about to check
                if (SplashKit.KeyTyped(KeyCode.FKey))
                {
                    SplashKit.CurrentWindowToggleFullscreen();
                }

                SplashKit.ClearScreen(Color.White);

                // Check every frame so the text always matches what the window is doing
                bool isFullscreen = SplashKit.CurrentWindowIsFullscreen();

                if (isFullscreen)
                {
                    SplashKit.DrawText("Fullscreen: true", Color.Black, "arial", 48, 40, 60);
                }
                else
                {
                    SplashKit.DrawText("Fullscreen: false", Color.Black, "arial", 48, 40, 60);
                }

                SplashKit.DrawText("Press F to switch", Color.DarkGray, "arial", 28, 40, 150);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
