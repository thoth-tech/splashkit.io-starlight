using SplashKitSDK;

namespace DrawCircleOnWindow
{
    public class Program
    {
        public static void Main()
        {
        Window myWindow = SplashKit.OpenWindow("Draw Circle on Window", 800, 600);
        SplashKit.ClearScreen();

        Random random = new Random();
        for (int i = 0; i < 50; i++)
        {
            double x = random.Next(800);
            double y = random.Next(600);
            double radius = random.Next(50);

            Color randomColor = SplashKit.RGBColor(
                random.Next(255), random.Next(255), random.Next(255)  
            );

            SplashKit.DrawCircleOnWindow(myWindow, randomColor, x, y, radius);
        }

        SplashKit.RefreshScreen();
        SplashKit.Delay(4000);

        SplashKit.CloseAllWindows();
        }
    }
}

