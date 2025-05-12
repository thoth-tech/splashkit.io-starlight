using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Ball Throw with Mouse", 800, 600);

// Load the ball bitmap
Bitmap ballBitmap = LoadBitmap("ball", "ball_sprite.png");
Sprite ball = CreateSprite(ballBitmap);

// Center the ball on the screen
SpriteSetX(ball, 0);
SpriteSetY(ball, 350);

Vector2D velocity = new Vector2D();

while (!QuitRequested())
{
    ProcessEvents();

    // Throw the ball toward the mouse when clicked
    if (MouseClicked(MouseButton.LeftButton))
    {
        Point2D ballPos = SpriteCenterPoint(ball);
        Point2D target = MousePosition();
        Vector2D direction = UnitVector(VectorPointToPoint(ballPos, target));

        velocity = VectorMultiply(direction, 8); // adjust throw strength
    }

    // Move the ball
    MoveSprite(ball, velocity);

    ClearScreen(Color.White);
    DrawSprite(ball);
    RefreshScreen(60);
}
