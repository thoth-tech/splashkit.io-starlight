using SplashKitSDK;

namespace DrawRactangle
{
    public class Program
    {
        public static void Main()
        {
        SplashKit.OpenWindow("Draw Rectangle", 800, 600);
        SplashKit.ClearScreen();

        for (int i = 0; i < 21; i++)
        {
            int x = i * 40 - 40;
            int y = 600 - i * 30;

            Color randomColor = SplashKit.RGBColor(
                SplashKit.Rnd(255), SplashKit.Rnd(255), SplashKit.Rnd(255)
            );

            SplashKit.DrawRectangle(randomColor, x, y, 40, 30);
        }

        SplashKit.RefreshScreen();
        SplashKit.Delay(4000);
        SplashKit.CloseAllWindows();
        }
    }
}



