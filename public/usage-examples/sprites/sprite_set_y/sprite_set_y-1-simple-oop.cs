using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
         
<<<<<<< Updated upstream
            Window myWindow = SplashKit.OpenWindow("sprite_set_y", 600, 600);
=======
            SplashKit.OpenWindow("sprite_set_y", 600, 600);
>>>>>>> Stashed changes
            
            Bitmap playerBitmap = SplashKit.LoadBitmap("player", "player-run.png");
            
            Sprite playerSprite = SplashKit.CreateSprite(playerBitmap);

           
            SplashKit.SpriteSetY(playerSprite, 300);
            SplashKit.ClearScreen(Color.Black);
            SplashKit.DrawSprite(playerSprite);
            SplashKit.RefreshScreen();
            SplashKit.Delay(5000);
<<<<<<< Updated upstream
            SplashKit.CloseWindow(myWindow);
=======
            SplashKit.CloseAllWindows();
>>>>>>> Stashed changes
    }
  }
}