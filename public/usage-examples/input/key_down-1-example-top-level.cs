using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Live Key Press Display", 800, 400);

while (!QuitRequested())
{
    ProcessEvents();

    bool spacePressed = KeyDown(KeyCode.SpaceKey);
    bool leftPressed = KeyDown(KeyCode.LeftKey);
    bool rightPressed = KeyDown(KeyCode.RightKey);
    bool upPressed = KeyDown(KeyCode.UpKey);
    bool downPressed = KeyDown(KeyCode.DownKey);

    ClearScreen(ColorWhite());

    DrawText("Hold the keys to see their current state.", ColorBlack(), 20, 20);

    DrawKeyState("Space", spacePressed, 20, 80);
    DrawKeyState("Left", leftPressed, 20, 130);
    DrawKeyState("Right", rightPressed, 20, 180);
    DrawKeyState("Up", upPressed, 20, 230);
    DrawKeyState("Down", downPressed, 20, 280);

    RefreshScreen(60);
}

CloseAllWindows();

void DrawKeyState(string keyName, bool isPressed, double x, double y)
{
    Color circleColor;

    if (isPressed)
    {
        circleColor = ColorGreen();
    }
    else
    {
        circleColor = ColorGray();
    }

    FillCircle(circleColor, x + 15, y + 15, 15);
    DrawCircle(ColorBlack(), x + 15, y + 15, 15);

    if (isPressed)
    {
        DrawText(keyName + ": Pressed", ColorBlack(), x + 40, y);
    }
    else
    {
        DrawText(keyName + ": Released", ColorBlack(), x + 40, y);
    }
}