using SplashKitSDK;

namespace SpriteTriangleCollisionExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Move the Sprite into the Triangle", 800, 600);

            // Prepare the generated bitmap pixels for collision testing
            Bitmap spriteBitmap = SplashKit.CreateBitmap("blue square", 40, 40);
            SplashKit.ClearBitmap(spriteBitmap, SplashKit.ColorBlue());
            SplashKit.SetupCollisionMask(spriteBitmap);
            Sprite testSprite = SplashKit.CreateSprite(spriteBitmap);

            Triangle collisionArea = SplashKit.TriangleFrom(400, 120, 650, 500, 150, 500);
            Point2D mouseLocation;
            string statusText;
            Color triangleColor;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Let the user test the triangle area by moving the sprite
                mouseLocation = SplashKit.MousePosition();
                SplashKit.SpriteSetPosition(testSprite, mouseLocation);

                if (SplashKit.SpriteTriangleCollision(testSprite, collisionArea))
                {
                    triangleColor = SplashKit.ColorGreen();
                    statusText = "Collision detected!";
                }
                else
                {
                    triangleColor = SplashKit.ColorRed();
                    statusText = "No collision detected.";
                }

                SplashKit.ClearScreen(SplashKit.ColorWhite());
                SplashKit.FillTriangle(triangleColor, collisionArea);
                SplashKit.DrawSprite(testSprite);
                SplashKit.DrawText("Move the blue sprite into the triangle", SplashKit.ColorBlack(), 20, 20);
                SplashKit.DrawText(statusText, SplashKit.ColorBlack(), 20, 50);
                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
