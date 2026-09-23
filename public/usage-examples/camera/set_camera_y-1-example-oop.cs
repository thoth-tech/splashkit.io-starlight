using SplashKitSDK;

namespace SetCameraYExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Set Camera Y Example", 800, 600);

            double y = 0;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyDown(KeyCode.UpKey))
                    y -= 5;

                if (SplashKit.KeyDown(KeyCode.DownKey))
                    y += 5;

                SplashKit.SetCameraY(y);

                SplashKit.ClearScreen(SplashKit.ColorWhite());

                SplashKit.FillRectangle(SplashKit.ColorRed(), 200, 100, 100, 100);
                SplashKit.FillRectangle(SplashKit.ColorGreen(), 200, 1000, 100, 100);

                SplashKit.DrawText(
                    "Camera Y: " + SplashKit.CameraY().ToString(),
                    SplashKit.ColorBlack(),
                    20,
                    20,
                    SplashKit.OptionToScreen()
                );

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}