using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a window
OpenWindow("Move Camera To Example", 800, 600);

// Create a player bitmap and sprite
Bitmap playerBmp = CreateBitmap("player", 40, 40);
ClearBitmap(playerBmp, ColorBrightGreen());
Sprite player = CreateSprite(playerBmp);

// Position the player further out in the game world
SpriteSetX(player, 1000);
SpriteSetY(player, 1000);

while (!QuitRequested())
{
    // Handle input to move the player
    ProcessEvents();

    if (KeyDown(KeyCode.LeftKey)) SpriteSetX(player, SpriteX(player) - 5);
    if (KeyDown(KeyCode.RightKey)) SpriteSetX(player, SpriteX(player) + 5);
    if (KeyDown(KeyCode.UpKey)) SpriteSetY(player, SpriteY(player) - 5);
    if (KeyDown(KeyCode.DownKey)) SpriteSetY(player, SpriteY(player) + 5);

    // Center camera on player when SPACE is pressed
    if (KeyTyped(KeyCode.SpaceKey))
    {
        // Calculate the top-left position for the camera to center the player
        double targetX = SpriteX(player) + SpriteWidth(player) / 2 - ScreenWidth() / 2;
        double targetY = SpriteY(player) + SpriteHeight(player) / 2 - ScreenHeight() / 2;
        
        // Move the camera to the calculated point
        MoveCameraTo(targetX, targetY);
    }

    // Reset camera to origin when M is pressed
    if (KeyTyped(KeyCode.MKey))
    {
        MoveCameraTo(0, 0);
    }

    // Clear the screen
    ClearScreen(ColorBlack());

    // Draw some world markers to visualize the camera move
    FillRectangle(ColorWhite(), 0, 0, 20, 20);
    DrawText("World (0,0)", ColorWhite(), 5, 25);

    FillRectangle(ColorRed(), 1000, 1000, 20, 20);
    DrawText("World (1000,1000)", ColorRed(), 1000, 1025);

    // Draw the sprite (automatically uses camera offset)
    DrawSprite(player);

    // Draw HUD (Heads-Up Display) directly to the screen
    FillRectangle(ColorDimGray(), 0, 0, 260, 80, OptionToScreen());
    DrawText($"Camera Position: {PointToString(CameraPosition())}", ColorWhite(), 10, 10, OptionToScreen());
    DrawText($"Player World Pos: ({(int)SpriteX(player)}, {(int)SpriteY(player)})", ColorWhite(), 10, 30, OptionToScreen());
    DrawText("Press SPACE to center on player", ColorWhite(), 10, 50, OptionToScreen());
    DrawText("Press M to move camera to (0,0)", ColorWhite(), 10, 65, OptionToScreen());

    RefreshScreen(60);
}

CloseAllWindows();
