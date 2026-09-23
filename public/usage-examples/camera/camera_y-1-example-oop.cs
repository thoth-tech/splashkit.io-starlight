using SplashKitSDK;

namespace CameraYExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Camera Y Example", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyDown(KeyCode.UpKey))
                    SplashKit.MoveCameraBy(0, -5);

                if (SplashKit.KeyDown(KeyCode.DownKey))
                    SplashKit.MoveCameraBy(0, 5);

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