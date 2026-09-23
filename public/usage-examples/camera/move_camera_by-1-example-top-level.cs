using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Move Camera By Example", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    // Move the camera using the arrow keys
    if (KeyDown(KeyCode.LeftKey))
        MoveCameraBy(-5, 0);

    if (KeyDown(KeyCode.RightKey))
        MoveCameraBy(5, 0);

    if (KeyDown(KeyCode.UpKey))
        MoveCameraBy(0, -5);

    if (KeyDown(KeyCode.DownKey))
        MoveCameraBy(0, 5);

    ClearScreen(ColorWhite());

    // Stationary objects in the game world
    FillRectangle(ColorRed(), 100, 200, 100, 100);
    FillCircle(ColorBlue(), 600, 300, 50);
    FillRectangle(ColorGreen(), 1100, 200, 100, 100);
    FillCircle(ColorRed(), 600, 800, 60);

    DrawText(
        "Use arrow keys to move the camera",
        ColorBlack(),
        20,
        20,
        OptionToScreen()
    );

    RefreshScreen(60);
}

CloseAllWindows();