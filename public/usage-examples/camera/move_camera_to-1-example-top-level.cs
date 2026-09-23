using SplashKitSDK;
using static SplashKitSDK.SplashKit;

const int ScreenWidth = 800;
const int ScreenHeight = 600;
const int WorldWidth = 1600;
const int WorldHeight = 1000;

const double PlayerSize = 40;
const double MovementSpeed = 5;

OpenWindow(
    "Move Camera To Example",
    ScreenWidth,
    ScreenHeight
);

double playerX = 380;
double playerY = 280;

while (!QuitRequested())
{
    ProcessEvents();

    if (KeyDown(KeyCode.LeftKey) || KeyDown(KeyCode.AKey))
    {
        playerX -= MovementSpeed;
    }

    if (KeyDown(KeyCode.RightKey) || KeyDown(KeyCode.DKey))
    {
        playerX += MovementSpeed;
    }

    if (KeyDown(KeyCode.UpKey) || KeyDown(KeyCode.WKey))
    {
        playerY -= MovementSpeed;
    }

    if (KeyDown(KeyCode.DownKey) || KeyDown(KeyCode.SKey))
    {
        playerY += MovementSpeed;
    }

    // Keep the player within the world.
    if (playerX < 0)
    {
        playerX = 0;
    }

    if (playerX > WorldWidth - PlayerSize)
    {
        playerX = WorldWidth - PlayerSize;
    }

    if (playerY < 0)
    {
        playerY = 0;
    }

    if (playerY > WorldHeight - PlayerSize)
    {
        playerY = WorldHeight - PlayerSize;
    }

    // Centre the camera on the player.
    double cameraX =
        playerX + PlayerSize / 2 - ScreenWidth / 2.0;

    double cameraY =
        playerY + PlayerSize / 2 - ScreenHeight / 2.0;

    // Keep the camera within the world.
    if (cameraX < 0)
    {
        cameraX = 0;
    }

    if (cameraX > WorldWidth - ScreenWidth)
    {
        cameraX = WorldWidth - ScreenWidth;
    }

    if (cameraY < 0)
    {
        cameraY = 0;
    }

    if (cameraY > WorldHeight - ScreenHeight)
    {
        cameraY = WorldHeight - ScreenHeight;
    }

    // Move the camera to the calculated world position.
    MoveCameraTo(cameraX, cameraY);

    ClearScreen(ColorWhite());

    // Draw a simple grid to show camera movement.
    for (int x = 0; x <= WorldWidth; x += 200)
    {
        DrawLine(
            ColorLightGray(),
            x,
            0,
            x,
            WorldHeight
        );
    }

    for (int y = 0; y <= WorldHeight; y += 200)
    {
        DrawLine(
            ColorLightGray(),
            0,
            y,
            WorldWidth,
            y
        );
    }

    // Draw simple landmarks within the world.
    FillRectangle(ColorGreen(), 100, 100, 180, 120);
    FillCircle(ColorRed(), 800, 450, 70);
    FillRectangle(ColorOrange(), 1300, 750, 180, 120);

    // Draw the world boundary and player.
    DrawRectangle(
        ColorBlack(),
        0,
        0,
        WorldWidth,
        WorldHeight
    );

    FillRectangle(
        ColorBlue(),
        playerX,
        playerY,
        PlayerSize,
        PlayerSize
    );

    RefreshScreen(60);
}

CloseAllWindows();