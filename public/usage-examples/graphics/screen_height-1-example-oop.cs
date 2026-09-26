using SplashKitSDK;

namespace ScreenHeightExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Screen Height", 800, 600);

            int height = SplashKit.ScreenHeight();
            Line l = SplashKit.LineFrom(SplashKit.ScreenWidth() / 2, 0, SplashKit.ScreenWidth() / 2, height);
            string text = $"The screen is {height} pixels tall";

            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawLine(Color.Black, l);
            SplashKit.FillTriangle(Color.Black, l.StartPoint.X, l.StartPoint.Y, l.StartPoint.X - 10, l.StartPoint.Y + 10, l.StartPoint.X + 10, l.StartPoint.Y + 10);
            SplashKit.FillTriangle(Color.Black, l.EndPoint.X, l.EndPoint.Y, l.EndPoint.X + 10, l.EndPoint.Y - 10, l.EndPoint.X - 10, l.EndPoint.Y - 10);
            SplashKit.DrawText(text, Color.Black, SplashKit.ScreenWidth() / 2 + 20, SplashKit.ScreenHeight() / 2);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}