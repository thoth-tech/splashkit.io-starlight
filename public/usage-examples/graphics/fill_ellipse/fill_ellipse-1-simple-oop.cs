using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Fill Ellipse", 800, 600);

            SplashKit.ClearScreen();
            SplashKit.FillEllipse(SplashKit.ColorBlue(), 200, 200, 400, 200);
            //Added a rectangle with the same arguments as above for x, y, width, and height 
            SplashKit.DrawRectangle(SplashKit.ColorRed(), 200, 200, 400, 200);
            SplashKit.RefreshScreen();

            SplashKit.Delay(4000);

            SplashKit.CloseAllWindows();
        }
    }
}
