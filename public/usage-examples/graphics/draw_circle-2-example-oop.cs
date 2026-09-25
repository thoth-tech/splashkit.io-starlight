using SplashKitSDK;

namespace DrawCircleAnimationExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Circle Animation", 800, 600);

            double x = 0;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                // Move the circle across the screen and wrap around
                SplashKit.DrawCircle(Color.Red, x, 300, 50);

                x += 2;
                if (x > 800)
                {
                    x = 0;
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
