using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
         
            Window myWindow = SplashKit.OpenWindow("sprite_set_x", 600, 600);

            
            Bitmap playerBitmap = SplashKit.LoadBitmap("player", "player-run.png");

            
            Sprite playerSprite = SplashKit.CreateSprite(playerBitmap);

           
            SplashKit.SpriteSetX(playerSprite, 300);
            SplashKit.ClearScreen(Color.Black);
            SplashKit.DrawSprite(playerSprite);
            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);
            SplashKit.CloseWindow(myWindow);
    }
  }
}