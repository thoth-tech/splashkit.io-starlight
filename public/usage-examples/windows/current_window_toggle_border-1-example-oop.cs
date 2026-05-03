using SplashKitSDK;

namespace CurrentWindowToggleBorderExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Press B to Toggle Border", 700, 250);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyTyped(KeyCode.BKey))
                {
                    SplashKit.CurrentWindowToggleBorder();
                }

                string borderState = SplashKit.CurrentWindowHasBorder() ? "On" : "Off";

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Press B to toggle border", Color.Black, 20, 20);
                SplashKit.DrawText("Border: " + borderState, Color.Blue, 20, 80);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}