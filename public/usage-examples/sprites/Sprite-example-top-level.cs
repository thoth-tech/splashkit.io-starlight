using SplashKitSDK;

// Global state
Sprite currentSprite;
string loadedSprite = "";

// Load sprite from image
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
        SplashKit.SpriteSetPosition(currentSprite, SplashKit.PointAt(400, 300));
        loadedSprite = spriteId;
    }
}

// Handle movement and switching
void HandleInput()
{
    Vector2D velocity = SplashKit.VectorTo(0, 0);

    if (SplashKit.KeyDown(KeyCode.UpKey)) velocity.Y = -3;
    if (SplashKit.KeyDown(KeyCode.DownKey)) velocity.Y = 3;
    if (SplashKit.KeyDown(KeyCode.LeftKey)) velocity.X = -3;
    if (SplashKit.KeyDown(KeyCode.RightKey)) velocity.X = 3;

    SplashKit.SpriteSetVelocity(currentSprite, velocity);

    if (SplashKit.KeyTyped(KeyCode.Num1Key)) LoadSprite("player1", "player1.png");
    if (SplashKit.KeyTyped(KeyCode.Num2Key)) LoadSprite("player2", "player2.png");
}

// Main loop
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
    SplashKit.DrawText("Use arrow keys to move. Press 1 or 2 to switch..", Color.Black, 10, 10);
    SplashKit.RefreshScreen(60);
}
