using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a game window
OpenWindow("Avoid the Obstacle", 600, 400);

// Player circle properties
float playerX = 300;
float playerY = 200;
const float playerRadius = 30;

// Obstacle circle properties
float obstacleX = 100;
float obstacleY = 100;
const float obstacleRadius = 30;
float obstacleSpeedX = 0.3f;
float obstacleSpeedY = 0.3f;

while (!QuitRequested())
{
    ProcessEvents();

    // Move the player circle using arrow keys
    if (KeyDown(KeyCode.UpKey))
        playerY -= 0.5f;
    if (KeyDown(KeyCode.DownKey))
        playerY += 0.5f;
    if (KeyDown(KeyCode.LeftKey))
        playerX -= 0.5f;
    if (KeyDown(KeyCode.RightKey))
        playerX += 0.5f;

    // Prevent the player from going off-screen (soft wall boundaries)
    if (playerX - playerRadius < 0)
        playerX = playerRadius;
    if (playerX + playerRadius > 600)
        playerX = 600 - playerRadius;
    if (playerY - playerRadius < 0)
        playerY = playerRadius;
    if (playerY + playerRadius > 400)
        playerY = 400 - playerRadius;

    // Move the obstacle
    obstacleX += obstacleSpeedX;
    obstacleY += obstacleSpeedY;

    // Bounce the obstacle off window edges
    if (obstacleX - obstacleRadius < 0 || obstacleX + obstacleRadius > 600)
        obstacleSpeedX *= -1;
    if (obstacleY - obstacleRadius < 0 || obstacleY + obstacleRadius > 400)
        obstacleSpeedY *= -1;

    // Change background color to red if a collision is detected, otherwise white
    if (CirclesIntersect(playerX, playerY, playerRadius, obstacleX, obstacleY, obstacleRadius))
        ClearScreen(ColorRed());
    else
        ClearScreen(ColorWhite());

    // Draw the player and the obstacle
    FillCircle(ColorBlue(), playerX, playerY, playerRadius);
    FillCircle(ColorRed(), obstacleX, obstacleY, obstacleRadius);

    // Refresh screen and delay
    RefreshScreen();
    Delay(10);
}

CloseAllWindows();
