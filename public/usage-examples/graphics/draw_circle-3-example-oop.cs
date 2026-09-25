using SplashKitSDK;

namespace DrawCircleInteractiveExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Interactive Circle", 800, 600);

            double x = 400;
            double y = 300;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                // Move the circle while the matching arrow key is held
                if (SplashKit.KeyDown(KeyCode.LeftKey))
                {
                    x -= 5;
                }
                if (SplashKit.KeyDown(KeyCode.RightKey))
                {
                    x += 5;
                }
                if (SplashKit.KeyDown(KeyCode.UpKey))
                {
                    y -= 5;
                }
                if (SplashKit.KeyDown(KeyCode.DownKey))
                {
                    y += 5;
                }

                SplashKit.DrawCircle(Color.Blue, x, y, 50);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
