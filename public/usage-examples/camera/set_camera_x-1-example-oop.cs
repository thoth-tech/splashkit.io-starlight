using SplashKitSDK;

namespace SetCameraXExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Set Camera X Example", 800, 600);

            double x = 0;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.KeyDown(KeyCode.LeftKey))
                    x -= 5;

                if (SplashKit.KeyDown(KeyCode.RightKey))
                    x += 5;

                SplashKit.SetCameraX(x);

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