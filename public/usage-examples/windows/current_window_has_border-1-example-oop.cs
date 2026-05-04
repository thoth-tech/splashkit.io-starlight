using SplashKitSDK;

namespace CurrentWindowHasBorderExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Current Window Has Border", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Press B to toggle the current window border
                if (SplashKit.KeyTyped(KeyCode.BKey))
                {
                    SplashKit.CurrentWindowToggleBorder();
                }

                // Check whether the current window has a border
                bool hasBorder = SplashKit.CurrentWindowHasBorder();

                SplashKit.ClearScreen(Color.White);

                // Show the current border state on screen
                SplashKit.DrawText("Press B to toggle the window border.", Color.Black, 170, 220);

                if (hasBorder)
                {
                    SplashKit.DrawText("Current window has a border", Color.Green, 210, 280);
                }
                else
                {
                    SplashKit.DrawText("Current window does not have a border", Color.Red, 150, 280);
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}