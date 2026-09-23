using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Set Camera Position Example", 400, 300);

double cameraX = 0;

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(ColorWhite());

    // Move the camera position each frame
    SetCameraPosition(PointAt(cameraX, 0));
    cameraX += 1;

    // A stationary object in the world - it does not move itself
    FillRectangle(ColorRed(), 200, 100, 50, 50);

    RefreshScreen(60);
}

CloseAllWindows();