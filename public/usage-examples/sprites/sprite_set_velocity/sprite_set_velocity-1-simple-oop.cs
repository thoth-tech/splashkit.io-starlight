using SplashKitSDK;

namespace velocity
{
    public class Program
    {
        public static void Main()
        {
            // Open a new window
            SplashKit.OpenWindow("Sprite Set Velocity", 600, 600);

            // Load bitmap and create sprite
            SplashKit.LoadBitmap("player", "player-run.png");
            Sprite playerSprite = SplashKit.CreateSprite(("player"));
            SplashKit.SpriteSetX(playerSprite, 300);
            SplashKit.SpriteSetY(playerSprite, 300);

            // Create vector for sprite's velocity
            Vector2D vel = SplashKit.VectorTo(0.01, 0);

            // Game loop
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Set sprite velocity and update sprite
                SplashKit.SpriteSetVelocity(playerSprite, vel);
                SplashKit.UpdateSprite(playerSprite);

                SplashKit.ClearScreen(SplashKit.ColorBlack());
                SplashKit.DrawSprite(playerSprite);
                SplashKit.RefreshScreen();
            }

            // Close all windows
            SplashKit.CloseAllWindows();
        }
    }
}
