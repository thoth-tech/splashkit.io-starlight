using SplashKitSDK;

// Global sprite and tracking info
Sprite currentSprite;
string loadedSprite = "";

// Load sprite from image and center it
void LoadSprite(string spriteId, string filename)
{
    if (loadedSprite != spriteId)
    {
        SplashKit.FreeAllSprites();

        if (!SplashKit.HasBitmap(spriteId))
        {
            SplashKit.LoadBitmap(spriteId, filename);
        }

        currentSprite = SplashKit.CreateSprite(SplashKit.BitmapNamed(spriteId));
        loadedSprite = spriteId;

        float centerX = 800 / 2 - SplashKit.SpriteWidth(currentSprite) / 2;
        float centerY = 600 / 2 - SplashKit.SpriteHeight(currentSprite) / 2;
        SplashKit.SpriteSetPosition(currentSprite, SplashKit.PointAt(centerX, centerY));
    }
}

// Handle input
void HandleInput()
{
    Vector2D velocity = SplashKit.VectorTo(0, 0);

    if (SplashKit.KeyDown(KeyCode.UpKey)) velocity.Y = -3;
    if (SplashKit.KeyDown(KeyCode.DownKey)) velocity.Y = 3;
    if (SplashKit.KeyDown(KeyCode.LeftKey)) velocity.X = -3;
    if (SplashKit.KeyDown(KeyCode.RightKey)) velocity.X = 3;

    SplashKit.SpriteSetVelocity(currentSprite, velocity);

    if (SplashKit.KeyTyped(KeyCode.Num1Key))
        LoadSprite("player1", "player1.png");

    if (SplashKit.KeyTyped(KeyCode.Num2Key))
        LoadSprite("player2", "player2.png");
}

// Setup and loop
Window gameWindow = SplashKit.OpenWindow("Sprite Switcher", 800, 600);
LoadSprite("player1", "player1.png");

while (!SplashKit.WindowCloseRequested(gameWindow))
{
    SplashKit.ProcessEvents();
    HandleInput();
    SplashKit.UpdateSprite(currentSprite);
    SplashKit.MoveSprite(currentSprite);

    SplashKit.ClearScreen(Color.White);
    SplashKit.DrawSprite(currentSprite);
    SplashKit.DrawText("Use arrow keys to move. Press 1 or 2 to switch characters.", Color.Black, 10, 10);
    SplashKit.RefreshScreen(60);
}
