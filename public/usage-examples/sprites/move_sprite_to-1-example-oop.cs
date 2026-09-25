using SplashKitSDK;

namespace MoveSpriteToExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Move Sprite To Example", 600, 600);

            Bitmap playerBitmap = SplashKit.LoadBitmap("player_bitmap", "player.png");
            Sprite playerSprite = SplashKit.CreateSprite(playerBitmap);

            SplashKit.SpriteSetPosition(playerSprite, SplashKit.PointAt(100, 300));

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Move the sprite toward the position clicked by the user.
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    SplashKit.MoveSpriteTo(
                        playerSprite,
                        SplashKit.MouseX(),
                        SplashKit.MouseY()
                    );
                }

                SplashKit.UpdateSprite(playerSprite);

                SplashKit.ClearScreen(Color.Black);
                SplashKit.DrawText(
                    "Click anywhere to move the sprite",
                    Color.White,
                    150,
                    40
                );
                SplashKit.DrawSprite(playerSprite);
                SplashKit.RefreshScreen(60);
            }

            SplashKit.FreeSprite(playerSprite);
            SplashKit.FreeBitmap(playerBitmap);
        }
    }
}