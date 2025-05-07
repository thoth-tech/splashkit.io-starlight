using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open the main game window
OpenWindow("2D Player movement", 800, 600);

// Load the player bitmap from file
Bitmap playerBitmap = LoadBitmap("player", "player_sprite.png");

// Create a sprite for the player
Sprite playerSprite = CreateSprite(playerBitmap);

// Position the sprite in the center of the window
SpriteSetX(playerSprite, 400);
SpriteSetY(playerSprite, 300);

// Main game loop
while (!QuitRequested())
{
    ProcessEvents();

    // Move the sprite based on key input
    Vector2D movementVector = new Vector2D();

    if (KeyDown(KeyCode.WKey))
    {
        movementVector.Y -= 5;
    }
    if (KeyDown(KeyCode.SKey))
    {
        movementVector.Y += 5;
    }
    if (KeyDown(KeyCode.AKey))
    {
        movementVector.X -= 5;
    }
    if (KeyDown(KeyCode.DKey))
    {
        movementVector.X += 5;
    }

    MoveSprite(playerSprite, movementVector);

    ClearScreen(Color.White);
    DrawSprite(playerSprite);
    RefreshScreen(60);
}
