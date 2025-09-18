using SplashKitSDK;

namespace BitmapWidthExample
{
    public class Program
    {
        public static void Main()
        {
            int randomNumber = SplashKit.Rnd(275, 800);

            SplashKit.OpenWindow("Random Window Width", randomNumber, 100);

            SplashKit.ClearScreen(Color.White);

            SplashKit.DrawText($"This window is {SplashKit.CurrentWindowWidth()} pixels wide", Color.Black, 20, 20);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}