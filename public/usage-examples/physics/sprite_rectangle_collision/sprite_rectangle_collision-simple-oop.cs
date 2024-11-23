using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace SpriteRectangleCollisionDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open a new window
            OpenWindow("Bitmap Collisions", 315, 330);

            // Load the bitmap
            Bitmap skBmp = LoadBitmap("skbox", "skbox.png");

            // Create a sprite using the bitmap
            Sprite skSprite = CreateSprite(skBmp);

            // Define sprite and rectangle positions
            Point2D skSpriteLoc = new Point2D() { X = 50, Y = 50 };
            SpriteSetPosition(skSprite, skSpriteLoc);

            Rectangle testRectangle1 = new Rectangle() { X = 20, Y = 20, Width = 20, Height = 20 };
            Rectangle testRectangle2 = new Rectangle() { X = 150, Y = 200, Width = 20, Height = 20 };

            // Clear the screen and draw elements
            ClearScreen(ColorWhite());
            DrawSprite(skSprite);
            FillRectangle(ColorBlack(), testRectangle1);
            FillRectangle(ColorRed(), testRectangle2);

            // Check for collisions
            if (SpriteRectangleCollision(skSprite, testRectangle1))
                WriteLine("Black Rectangle Collision");
            if (SpriteRectangleCollision(skSprite, testRectangle2))
                WriteLine("Red Rectangle Collision");

            // Refresh the screen and delay before closing
            RefreshScreen();
            Delay(4000);

            CloseAllWindows();
        }
    }
}
