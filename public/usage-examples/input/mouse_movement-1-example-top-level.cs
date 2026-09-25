using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Mouse Movement Display", 800, 600);

double circleX = 400;
double circleY = 300;

while (!QuitRequested())
{
    ProcessEvents();

    Vector2D movement = MouseMovement();

    circleX += movement.X;
    circleY += movement.Y;

    ClearScreen(ColorWhite());

    DrawText("Move the mouse to see mouse_movement() values.", ColorBlack(), 20, 20);
    DrawText("Movement X: " + movement.X, ColorBlack(), 20, 60);
    DrawText("Movement Y: " + movement.Y, ColorBlack(), 20, 100);

    FillCircle(ColorBlue(), circleX, circleY, 15);
    DrawCircle(ColorBlack(), circleX, circleY, 15);

    DrawLine(ColorRed(), circleX, circleY, circleX + movement.X * 5, circleY + movement.Y * 5);

    RefreshScreen(60);
}

CloseAllWindows();