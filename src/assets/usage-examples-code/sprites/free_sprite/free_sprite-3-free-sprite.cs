using SplashKitSDK;

// Window to draw the sprite on
Window start = SplashKit.OpenWindow("create_sprite", 600, 600);

// Bitmap for creating a sprite
Bitmap player = SplashKit.LoadBitmap("playerBmp", "protSpriteSheet.png");
player.SetCellDetails(31, 32, 4, 3, 12); // Set cell details

// Creating the player sprite
Sprite playerSprite = SplashKit.CreateSprite(player);

// Setting the coordinates in reference to the window
playerSprite.X = 300;
playerSprite.Y = 300;

// Game loop
bool spriteExists = true; // Track if the sprite exists
while (!SplashKit.QuitRequested())
{
    SplashKit.ProcessEvents();
    SplashKit.ClearScreen(Color.Black);

    if (spriteExists)
    {
        SplashKit.DrawSprite(playerSprite);
        SplashKit.UpdateSprite(playerSprite);
    }

    SplashKit.RefreshScreen();

    // If UP key is typed, the sprite is removed
    if (spriteExists && SplashKit.KeyTyped(KeyCode.UpKey))
    {
        SplashKit.FreeSprite(playerSprite);
        spriteExists = false; // Set bool to false to stop drawing/updating
    }
}

// Cleanup
if (spriteExists)
{
    SplashKit.FreeSprite(playerSprite);
}

start.Close(); 