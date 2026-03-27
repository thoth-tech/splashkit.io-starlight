using SplashKitSDK;

namespace BitmapWidthExample
{
    public class Program
    {
        public static void Main()
        {
            Random rnd = new Random();

            SplashKit.OpenWindow("Random Window Height", 275, rnd.Next(100, 800));

            SplashKit.ClearScreen(Color.White);

            SplashKit.DrawText($"This window is {SplashKit.CurrentWindowHeight()} pixels tall", Color.Black, 20, 20);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}