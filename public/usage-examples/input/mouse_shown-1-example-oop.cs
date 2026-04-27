using SplashKitSDK;

namespace MouseShownExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Mouse Shown", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Press S to show the mouse, H to hide it
                if (SplashKit.KeyTyped(KeyCode.SKey))
                    SplashKit.ShowMouse();

                if (SplashKit.KeyTyped(KeyCode.HKey))
                    SplashKit.HideMouse();

                // MouseShown returns true if the mouse cursor is currently visible
                string status;
                if (SplashKit.MouseShown())
                    status = "Mouse is visible";
                else
                    status = "Mouse is hidden";

                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawText("Press S to show the mouse, H to hide it", Color.Black, "Arial", 18, 170, 250);
                SplashKit.DrawText(status, Color.Blue, "Arial", 24, 170, 290);
                SplashKit.RefreshScreen(60);
            }

            // Always show the mouse again before closing
            SplashKit.ShowMouse();
            SplashKit.CloseAllWindows();
        }
    }
}
