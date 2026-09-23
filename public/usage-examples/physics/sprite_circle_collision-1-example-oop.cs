using SplashKitSDK;

namespace SpriteCircleCollisionExample
{
    public class Program
    {
        public static void Main()
        {
            // Open a new window
            SplashKit.OpenWindow("Sprite Circle Collision", 540, 380);

            // Load the bitmap and create the sprite
            Bitmap spriteBitmap = SplashKit.LoadBitmap("player", "skbox.png");
            Sprite player = SplashKit.CreateSprite(spriteBitmap);

            // Position the sprite
            Point2D spritePosition = new Point2D()
            {
                X = 70,
                Y = 90
            };

            SplashKit.SpriteSetPosition(player, spritePosition);

            // Define the circles
            Circle collisionCircle = SplashKit.CircleAt(120, 140, 70);
            Circle clearCircle = SplashKit.CircleAt(460, 290, 40);

            // Clear the screen and draw the example
            SplashKit.ClearScreen(SplashKit.ColorWhite());

            SplashKit.FillCircle(SplashKit.ColorGreen(), collisionCircle);
            SplashKit.FillCircle(SplashKit.ColorRed(), clearCircle);
            SplashKit.DrawSprite(player);

            // Check the collisions
            if (SplashKit.SpriteCircleCollision(player, collisionCircle))
            {
                SplashKit.WriteLine("Green Circle Collision");
            }

            if (!SplashKit.SpriteCircleCollision(player, clearCircle))
            {
                SplashKit.WriteLine("No Red Circle Collision");
            }

            // Display the result briefly
            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);

            SplashKit.CloseAllWindows();
        }
    }
}
