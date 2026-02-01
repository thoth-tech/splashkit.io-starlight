using SplashKitSDK;

namespace ScreenWidthExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Screen Width", 800, 600);

            int width = SplashKit.ScreenWidth();
            string text = $"The screen is {width} pixels wide";

            SplashKit.ClearScreen(Color.White);
            SplashKit.FillRectangle(Color.Black, 0, SplashKit.ScreenHeight() / 2, width, 1);
            SplashKit.DrawText("<", Color.Black, -2, SplashKit.ScreenHeight() / 2 - 3);
            SplashKit.DrawText(">", Color.Black, width - 6, SplashKit.ScreenHeight() / 2 - 3);
            SplashKit.DrawText(text, Color.Black, (width / 2) - (SplashKit.TextWidth(text, "0", 0) / 2), SplashKit.ScreenHeight() / 2 - 20);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}