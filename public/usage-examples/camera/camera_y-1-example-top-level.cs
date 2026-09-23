using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Camera Y Example", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    if (KeyDown(KeyCode.UpKey))
        MoveCameraBy(0, -5);

    if (KeyDown(KeyCode.DownKey))
        MoveCameraBy(0, 5);

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