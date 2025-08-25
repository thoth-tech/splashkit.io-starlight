using SplashKitSDK;

namespace ScreenHeightExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Screen Height", 800, 600);

            int height = SplashKit.ScreenHeight();
            string text = $"The screen is {height} pixels tall";

            SplashKit.ClearScreen(Color.White);
            SplashKit.FillRectangle(Color.Black, SplashKit.ScreenWidth() / 2, 0, 1, height);
            SplashKit.DrawText("^", Color.Black, SplashKit.ScreenWidth() / 2 - 3, 0);
            SplashKit.DrawText("V", Color.Black, SplashKit.ScreenWidth() / 2 - 3, height - 8);
            SplashKit.DrawText(text, Color.Black, SplashKit.ScreenWidth() / 2 + 20, SplashKit.ScreenHeight() / 2);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}