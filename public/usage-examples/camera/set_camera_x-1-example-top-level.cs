using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Set Camera X Example", 800, 600);

double x = 0;

while (!QuitRequested())
{
    ProcessEvents();

    if (KeyDown(KeyCode.LeftKey))
        x -= 5;

    if (KeyDown(KeyCode.RightKey))
        x += 5;

    SetCameraX(x);

    ClearScreen(ColorWhite());

    FillRectangle(ColorRed(), 100, 200, 100, 100);
    FillRectangle(ColorGreen(), 1000, 200, 100, 100);

    DrawText(
        "Camera X: " + CameraX().ToString(),
        ColorBlack(),
        20,
        20,
        OptionToScreen()
    );

    RefreshScreen(60);
}

CloseAllWindows();