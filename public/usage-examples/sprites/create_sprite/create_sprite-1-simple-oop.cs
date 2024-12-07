using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Create Sprite", 800, 600);

            Bitmap playerBitmap = SplashKit.LoadBitmap("player", "player.png");

            Sprite playerSprite = SplashKit.CreateSprite(playerBitmap);

            playerSprite.X = 300;
            playerSprite.Y = 300;
            
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen(Color.Black);
            SplashKit.DrawSprite(playerSprite);
            SplashKit.RefreshWindow(myWindow);
            SplashKit.Delay(3000);
            SplashKit.CloseAllWindows();
        }
    }
}