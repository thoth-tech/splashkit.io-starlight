using SplashKitSDK;

namespace CurrentWindowHeightExample
{
    public class Program
    {
        public static void Main()
        {
            int randomNumber = SplashKit.Rnd(100, 800);

            SplashKit.OpenWindow("Random Window Height", 275, randomNumber);

            SplashKit.ClearScreen(Color.White);

            SplashKit.DrawText($"This window is {SplashKit.CurrentWindowHeight()} pixels tall", Color.Black, 20, 20);
            SplashKit.RefreshScreen();

            SplashKit.Delay(5000);

            SplashKit.CloseAllWindows();
        }
    }
}