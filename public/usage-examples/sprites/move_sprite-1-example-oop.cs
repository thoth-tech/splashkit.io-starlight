using SplashKitSDK;

namespace MoveSpriteExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Ball Throw with Mouse", 800, 600);

            // Load the ball bitmap
            Bitmap ballBitmap = SplashKit.LoadBitmap("ball", "ball_sprite.png");
            Sprite ball = SplashKit.CreateSprite(ballBitmap);

            // Center the ball on the screen
            SplashKit.SpriteSetX(ball, 0);
            SplashKit.SpriteSetY(ball, 350);

            Vector2D velocity = new Vector2D();

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Throw the ball toward the mouse when clicked
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Point2D ballPos = SplashKit.SpriteCenterPoint(ball);
                    Point2D target = SplashKit.MousePosition();
                    Vector2D direction = SplashKit.UnitVector(SplashKit.VectorPointToPoint(ballPos, target));

                    velocity = SplashKit.VectorMultiply(direction, 8); // throw strength
                }

                // Move the ball
                SplashKit.MoveSprite(ball, velocity);

                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawSprite(ball);
                SplashKit.RefreshScreen(60);
            }
        }
    }
}
