using static SplashKitSDK.SplashKit;
using SplashKitSDK;

OpenWindow("Camera Position Example", 800, 600);

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

    Point2D camera = CameraPosition();

    ClearScreen(ColorWhite());

    // Stationary objects in the world
    FillRectangle(ColorRed(), 100, 200, 100, 100);
    FillCircle(ColorBlue(), 600, 300, 50);
    FillRectangle(ColorGreen(), 1100, 200, 100, 100);

    DrawText(
        "Use arrow keys to move the camera",
        ColorBlack(),
        20,
        20,
        OptionToScreen()
    );

    DrawText(
        "Camera Position: " + PointToString(camera),
        ColorBlack(),
        20,
        50,
        OptionToScreen()
    );

    RefreshScreen(60);
}

CloseAllWindows();