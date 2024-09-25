using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a window to draw the sprite on
Window start = OpenWindow("spriteSetVelocity", 600, 600);

// Load bitmap for creating a sprite
Bitmap player = LoadBitmap("playerBmp", "player-run.png");

// Create the player sprite
Sprite playerSprite = CreateSprite(player);

// Set the coordinates in reference to the window
SpriteSetX(playerSprite, 300);
SpriteSetY(playerSprite, 300);

// Create vector for sprite's velocity
Vector2D vel = new Vector2D();
vel.X = 0.01;
vel.Y = 0;

// Game loop
while (!WindowCloseRequested(start))
{
    ProcessEvents();
    ClearScreen(Color.Black);

    // Set sprite velocity
    SpriteSetVelocity(playerSprite, vel);
    DrawSprite(playerSprite);
    UpdateSprite(playerSprite);

    RefreshScreen();
}

CloseWindow(start);