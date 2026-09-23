using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Sprite Add To Velocity Example", 400, 300);

// Create a small bitmap and draw a circle onto it to act as our sprite
Bitmap ballBitmap = CreateBitmap("BallBitmap", 30, 30);
FillCircleOnBitmap(ballBitmap, Color.Red, 15, 15, 15);

// Create the sprite using the bitmap, starting at the center of the window
Sprite ball = CreateSprite(ballBitmap);
SpriteSetPosition(ball, PointAt(185, 135));

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(Color.White);

    // Add a small amount of velocity in the direction of whichever arrow key is held
    if (KeyDown(KeyCode.UpKey))
    {
        SpriteAddToVelocity(ball, VectorTo(0, -0.05));
    }
    if (KeyDown(KeyCode.DownKey))
    {
        SpriteAddToVelocity(ball, VectorTo(0, 0.05));
    }
    if (KeyDown(KeyCode.LeftKey))
    {
        SpriteAddToVelocity(ball, VectorTo(-0.05, 0));
    }
    if (KeyDown(KeyCode.RightKey))
    {
        SpriteAddToVelocity(ball, VectorTo(0.05, 0));
    }

    UpdateSprite(ball);
    DrawSprite(ball);

    RefreshScreen(60);
}

CloseAllWindows();