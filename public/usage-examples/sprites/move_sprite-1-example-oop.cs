using SplashKitSDK;

namespace MoveSpriteExample
{
    public class Program
    {
        public static void Main()
        {
            // Open the main game window
            SplashKit.OpenWindow("Sprite Movement Example", 800, 600);

            // Load the player bitmap from file
            Bitmap playerBitmap = SplashKit.LoadBitmap("player", "player_sprite.png");

            // Create a sprite for the player
            Sprite playerSprite = SplashKit.CreateSprite(playerBitmap);

            // Position the sprite in the center of the window
            SplashKit.SpriteSetX(playerSprite, 400);
            SplashKit.SpriteSetY(playerSprite, 300);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Move the sprite based on key input
                Vector2D movementVector = new Vector2D();

                if (SplashKit.KeyDown(KeyCode.WKey))
                {
                    movementVector.Y -= 5;
                }
                if (SplashKit.KeyDown(KeyCode.SKey))
                {
                    movementVector.Y += 5;
                }
                if (SplashKit.KeyDown(KeyCode.AKey))
                {
                    movementVector.X -= 5;
                }
                if (SplashKit.KeyDown(KeyCode.DKey))
                {
                    movementVector.X += 5;
                }

                SplashKit.MoveSprite(playerSprite, movementVector);

                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawSprite(playerSprite);
                SplashKit.RefreshScreen(60);
            }
        }
    }
}
