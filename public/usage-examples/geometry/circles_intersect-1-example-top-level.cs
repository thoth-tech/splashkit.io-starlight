using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Open the gameplay window 
Window window = OpenWindow("Dodge the Bouncing Balls", 800, 600);

// Initialize player and enemy circles 
Circle playerCircle = CircleAt(400, 300, 20);
Circle enemyCircle1 = CircleAt(100, 100, 30);
Circle enemyCircle2 = CircleAt(700, 500, 30);

// Assign initial velocities to make enemies bounce off the window edges
double dx1 = 3, dy1 = 2;
double dx2 = -2, dy2 = -3;

// Run the main game loop until the player quits or a collision occurs
while (!WindowCloseRequested(window))
{
    ProcessEvents();

    // Update player position based on arrow key inputs
    if (KeyDown(KeyCode.LeftKey))
    {
        playerCircle.Center.X -= 5;
    }
    if (KeyDown(KeyCode.RightKey))
    {
        playerCircle.Center.X += 5;
    }
    if (KeyDown(KeyCode.UpKey))
    {
        playerCircle.Center.Y -= 5;
    }
    if (KeyDown(KeyCode.DownKey))
    {
        playerCircle.Center.Y += 5;
    }

    // Move enemy 1 and bounce off the edges of the window
    enemyCircle1.Center.X += dx1;
    enemyCircle1.Center.Y += dy1;
    if (enemyCircle1.Center.X < enemyCircle1.Radius || enemyCircle1.Center.X > ScreenWidth() - enemyCircle1.Radius)
    {
        dx1 = -dx1;
    }
    if (enemyCircle1.Center.Y < enemyCircle1.Radius || enemyCircle1.Center.Y > ScreenHeight() - enemyCircle1.Radius)
    {
        dy1 = -dy1;
    }

    // Move enemy 2 and bounce off the edges of the window
    enemyCircle2.Center.X += dx2;
    enemyCircle2.Center.Y += dy2;
    if (enemyCircle2.Center.X < enemyCircle2.Radius || enemyCircle2.Center.X > ScreenWidth() - enemyCircle2.Radius)
    {
        dx2 = -dx2;
    }
    if (enemyCircle2.Center.Y < enemyCircle2.Radius || enemyCircle2.Center.Y > ScreenHeight() - enemyCircle2.Radius)
    {
        dy2 = -dy2;
    }

    // Render player and enemy circles on screen
    ClearScreen(Color.White);
    FillCircle(Color.Green, playerCircle);
    FillCircle(Color.Red, enemyCircle1);
    FillCircle(Color.Red, enemyCircle2);
    RefreshScreen(60);

    // Display "Game Over" and exit if a collision is detected
    if (CirclesIntersect(playerCircle, enemyCircle1) || CirclesIntersect(playerCircle, enemyCircle2))
    {
        ClearScreen(Color.White);
        DrawText("Game Over", Color.Black, 350, 280);
        RefreshScreen(60);
        Delay(2000);
        break;
    }
}
