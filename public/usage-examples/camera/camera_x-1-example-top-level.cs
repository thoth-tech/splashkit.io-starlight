using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Camera X Example", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    if (KeyDown(KeyCode.LeftKey))
        MoveCameraBy(-5, 0);

    if (KeyDown(KeyCode.RightKey))
        MoveCameraBy(5, 0);

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