using SplashKitSDK;

namespace DisplayWidthExample
{
    public class Program
    {
        public static void Main()
        {
            Display display = SplashKit.DisplayDetails(0);
            int width = SplashKit.DisplayWidth(display);

            SplashKit.OpenWindow("Display Width", width, 600);

            Font font = SplashKit.FontNamed("Century.ttf");
            string text = $"The display is {width} pixels wide";
            
            SplashKit.ClearScreen(Color.White);
            SplashKit.FillRectangle(Color.Black, 0, SplashKit.ScreenHeight() / 2, width, 1);
            SplashKit.DrawText("<", Color.Black, -2, SplashKit.ScreenHeight() / 2 - 3);
            SplashKit.DrawText(">", Color.Black, width - 6, SplashKit.ScreenHeight() / 2 - 3);
            SplashKit.DrawText(text, Color.Black, font, 30, (SplashKit.ScreenWidth() / 2) - (SplashKit.TextWidth(text, font, 30) / 2), SplashKit.ScreenHeight() / 2 - 60);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}