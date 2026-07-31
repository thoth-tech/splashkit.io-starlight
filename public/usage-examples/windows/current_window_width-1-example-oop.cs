using SplashKitSDK;

namespace CurrentWindowWidthExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Current Window Width", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                int windowWidth = SplashKit.CurrentWindowWidth();

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Current window width:", Color.Black, 220, 220);
                SplashKit.DrawText(windowWidth.ToString() + " pixels", Color.Blue, 260, 270);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}