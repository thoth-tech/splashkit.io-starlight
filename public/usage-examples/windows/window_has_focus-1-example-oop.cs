using SplashKitSDK;

namespace WindowHasFocusExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Window Has Focus", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Check whether the current window has focus
                bool hasFocus = SplashKit.WindowHasFocus(SplashKit.CurrentWindow());

                SplashKit.ClearScreen(Color.White);

                // Show the current focus state on screen
                SplashKit.DrawText("Click on or away from the window to change focus.", Color.Black, 120, 220);

                if (hasFocus)
                {
                    SplashKit.DrawText("Window has focus", Color.Green, 280, 280);
                }
                else
                {
                    SplashKit.DrawText("Window does not have focus", Color.Red, 240, 280);
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}