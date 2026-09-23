using SplashKitSDK;

namespace CameraXExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Camera X Example", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyDown(KeyCode.LeftKey))
                    SplashKit.MoveCameraBy(-5, 0);

                if (SplashKit.KeyDown(KeyCode.RightKey))
                    SplashKit.MoveCameraBy(5, 0);

                SplashKit.ClearScreen(SplashKit.ColorWhite());

                SplashKit.FillRectangle(SplashKit.ColorRed(), 100, 200, 100, 100);
                SplashKit.FillRectangle(SplashKit.ColorGreen(), 1000, 200, 100, 100);

                SplashKit.DrawText(
                    "Camera X: " + SplashKit.CameraX().ToString(),
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