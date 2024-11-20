using SplashKitSDK;

namespace DrawEllipse
{
    public class Program
    {
        public static void Main()
        {
        SplashKit.OpenWindow("Draw Ellipse", 800, 600);
        SplashKit.ClearScreen();

        for (int i = 0; i < 30; i++)
        {
            int width = 600 - i * 20;
            int height = 400 - i * 10;
            int x = 100 + i * 10;
            int y = 100 + i * 5;

            Color randomColor = SplashKit.RGBColor(
                SplashKit.Rnd(255), SplashKit.Rnd(255), SplashKit.Rnd(255)
            );

            SplashKit.DrawEllipse(randomColor, x, y, width, height);
        }

        SplashKit.RefreshScreen();
        SplashKit.Delay(4000);

        SplashKit.CloseAllWindows();
        }
    }
}

