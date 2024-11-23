using static SplashKitSDK.SplashKit;
using SplashKitSDK;

namespace SpriteBitmapCollisionDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open a new window
            OpenWindow("Bitmap Collisions", 315, 330);

            // Load the bitmaps
            Bitmap skBmp = LoadBitmap("skbox", "skbox.png");
            Bitmap fileBmp = LoadBitmap("file", "file_image.png");
            Bitmap bugBmp = LoadBitmap("bug", "bug_image.png");

            // Create a sprite using the bitmap
            Sprite skSprite = CreateSprite(skBmp);

            // Define positions
            Point2D skSpriteLoc = new Point2D() { X = 50, Y = 50 };
            Point2D fileBmpLoc = new Point2D() { X = 20, Y = 20 };
            Point2D bugBmpLoc = new Point2D() { X = 200, Y = 150 };

            // Set sprite position
            SpriteSetPosition(skSprite, skSpriteLoc);

            // Clear the screen and draw all elements
            ClearScreen(ColorWhite());
            DrawSprite(skSprite);
            DrawBitmap(fileBmp, fileBmpLoc.X, fileBmpLoc.Y);
            DrawBitmap(bugBmp, bugBmpLoc.X, bugBmpLoc.Y);

            // Check for collisions
            if (SpriteBitmapCollision(skSprite, fileBmp, fileBmpLoc.X, fileBmpLoc.Y))
                WriteLine("SplashKit got a new file!");

            if (SpriteBitmapCollision(skSprite, bugBmp, bugBmpLoc.X, bugBmpLoc.Y))
                WriteLine("SplashKit has bugs!");

            // Refresh the screen and delay before closing
            RefreshScreen();
            Delay(4000);

            CloseAllWindows();
        }
    }
}
