using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Set Camera Y Example", 800, 600);

double y = 0;

while (!QuitRequested())
{
    ProcessEvents();

    if (KeyDown(KeyCode.UpKey))
        y -= 5;

    if (KeyDown(KeyCode.DownKey))
        y += 5;

    SetCameraY(y);

    ClearScreen(ColorWhite());

    FillRectangle(ColorRed(), 200, 100, 100, 100);
    FillRectangle(ColorGreen(), 200, 1000, 100, 100);

    DrawText(
        "Camera Y: " + CameraY().ToString(),
        ColorBlack(),
        20,
        20,
        OptionToScreen()
    );

    RefreshScreen(60);
}

CloseAllWindows();