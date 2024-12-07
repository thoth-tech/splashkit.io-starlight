using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Clover Drawing with Fill Ellipse", 1000, 600);

            SplashKit.ClearScreen();
            SplashKit.FillEllipse(SplashKit.ColorGreen(), 150, 225, 400, 200);
            SplashKit.FillEllipse(SplashKit.ColorGreen(), 375, 0, 200, 400);
            SplashKit.FillEllipse(SplashKit.ColorGreen(), 400, 225, 400, 200);
            SplashKit.FillRectangle(SplashKit.ColorBrown(), 470, 400, 10, 150);
            SplashKit.RefreshScreen();

            SplashKit.Delay(4000);

            SplashKit.CloseAllWindows();
        }
    }
}
