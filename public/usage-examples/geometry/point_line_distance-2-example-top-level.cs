
using SplashKitSDK;

const int WindowWidth  = 800;
const int WindowHeight = 600;
const double MaxDistance = 50;

// Create the game window
Window gameWindow = new Window("Stay Close to the Line", WindowWidth, WindowHeight);

// Define the line 
Point2D lineStart = new Point2D { X = 100, Y = 300 };
Point2D lineEnd   = new Point2D { X = 700, Y = 300 };
Line   pathLine   = SplashKit.LineFrom(lineStart, lineEnd);

// Define the player point
Point2D player = new Point2D { X = 400, Y = 300 };

while (!gameWindow.CloseRequested)
{
    SplashKit.ProcessEvents();

    // Player movement
    if (SplashKit.KeyDown(KeyCode.UpKey))    player.Y -= 5;
    if (SplashKit.KeyDown(KeyCode.DownKey))  player.Y += 5;
    if (SplashKit.KeyDown(KeyCode.LeftKey))  player.X -= 5;
    if (SplashKit.KeyDown(KeyCode.RightKey)) player.X += 5;

    // Distance from player to the line
    double distance = SplashKit.PointLineDistance(player, pathLine);

    // Draw scene
    gameWindow.Clear(Color.White);
    gameWindow.DrawLine(Color.Black, lineStart, lineEnd);
    // Unpack player.X/Y into FillCircle
    gameWindow.FillCircle(Color.Green, player.X, player.Y, 5);

    // Check for game over
    if (distance > MaxDistance)
    {
        gameWindow.DrawText("Game Over – Too Far from the Line", Color.Red, 200, 50);
        gameWindow.Refresh();
        SplashKit.Delay(2000);
        break;
    }

    // Cap the frame‐rate
    gameWindow.Refresh(60);
}

gameWindow.Close();