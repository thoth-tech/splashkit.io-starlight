using System;
using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Window to draw the sprite on
Window start = OpenWindow("createSprite", 600, 600);

// Bitmap for creating a sprite
Bitmap player = LoadBitmap("playerBitmap", "player.png");
player.SetCellDetails(31, 32, 4, 3, 12); // Set cell details

// Creating the player sprite
Sprite playerSprite = CreateSprite(player);

// Setting the coordinates in reference to the window
playerSprite.X = 300;
playerSprite.Y = 300;

// Game loop
bool spriteExists = true; // Track if the sprite exists
while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(Color.Black);

    if (spriteExists)
    {
        DrawSprite(playerSprite);
        UpdateSprite(playerSprite);
    }

    RefreshScreen();

    // If UP key is typed, the sprite is removed
    if (spriteExists && KeyTyped(KeyCode.UpKey))
    {
        FreeSprite(playerSprite);
        spriteExists = false; // Set bool to false to stop drawing/updating
    }
}

// Cleanup
if (spriteExists)
{
    FreeSprite(playerSprite);
}

start.Close();