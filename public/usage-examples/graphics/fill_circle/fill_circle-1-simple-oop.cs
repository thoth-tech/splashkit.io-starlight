using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Fill Circle", 800, 600);

            SplashKit.ClearScreen();
            SplashKit.FillCircle(SplashKit.ColorBlue(), 300, 300, 200);
            SplashKit.RefreshScreen();

            SplashKit.Delay(4000);

            SplashKit.CloseAllWindows();
        }
    }
}
