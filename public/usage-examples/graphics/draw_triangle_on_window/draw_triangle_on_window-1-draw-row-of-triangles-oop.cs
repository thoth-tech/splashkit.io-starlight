using SplashKitSDK;

namespace DrawCircleOnWindow
{
    public class Program
    {
        public static void Main()
        {
        Window myWindow = SplashKit.OpenWindow("Draw Triangle on Window", 800, 600);
        SplashKit.ClearScreen();

        Random random = new Random();
        for (int i = 0; i < 20; i++)
        {
            double x = 40 * i;

            Color randomColor = SplashKit.RGBColor(
                random.Next(255), random.Next(255), random.Next(255)  
            );

            SplashKit.DrawTriangleOnWindow(myWindow, randomColor, 0 + x, 0, 20 + x, 40, 40 + x, 0);
        }

        SplashKit.RefreshScreen();
        SplashKit.Delay(4000);

        SplashKit.CloseAllWindows();
        }
    }
}

