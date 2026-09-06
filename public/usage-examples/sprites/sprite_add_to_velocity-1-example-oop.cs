using SplashKitSDK;

namespace SpriteAddToVelocityExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Sprite Add To Velocity Example", 400, 300);

            // Create a small bitmap and draw a circle onto it to act as our sprite
            Bitmap ballBitmap = SplashKit.CreateBitmap("BallBitmap", 30, 30);
            SplashKit.FillCircleOnBitmap(ballBitmap, Color.Red, 15, 15, 15);

            // Create the sprite using the bitmap, starting at the center of the window
            Sprite ball = SplashKit.CreateSprite(ballBitmap);
            SplashKit.SpriteSetPosition(ball, SplashKit.PointAt(185, 135));

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                // Add a small amount of velocity in the direction of whichever arrow key is held
                if (SplashKit.KeyDown(KeyCode.UpKey))
                {
                    ball.AddToVelocity(SplashKit.VectorTo(0, -0.05));
                }
                if (SplashKit.KeyDown(KeyCode.DownKey))
                {
                    ball.AddToVelocity(SplashKit.VectorTo(0, 0.05));
                }
                if (SplashKit.KeyDown(KeyCode.LeftKey))
                {
                    ball.AddToVelocity(SplashKit.VectorTo(-0.05, 0));
                }
                if (SplashKit.KeyDown(KeyCode.RightKey))
                {
                    ball.AddToVelocity(SplashKit.VectorTo(0.05, 0));
                }

                SplashKit.UpdateSprite(ball);
                SplashKit.DrawSprite(ball);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}