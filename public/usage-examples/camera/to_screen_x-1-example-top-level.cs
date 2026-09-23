using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Landmark Tracker", 800, 450);

// The tower stays at this world position, wherever the camera is looking
double towerX = 400;

while (!QuitRequested())
{
    ProcessEvents();

    // The arrow keys slide the camera along the world
    if (KeyDown(KeyCode.LeftKey))
    {
        MoveCameraBy(-4, 0);
    }

    if (KeyDown(KeyCode.RightKey))
    {
        MoveCameraBy(4, 0);
    }

    ClearScreen(ColorWhite());

    // Shapes are drawn in world coordinates, so they slide across the window with the camera
    DrawLine(ColorGray(), -2000, 350, 4000, 350);
    FillRectangle(ColorDarkRed(), towerX - 20, 230, 40, 120);

    // Ask the camera where the tower's world position appears on the screen
    double towerScreenX = ToScreenX(towerX);

    // A marker at that screen position, drawn with OptionToScreen() so the camera does not move it
    DrawLine(ColorBlue(), towerScreenX, 100, towerScreenX, 395, OptionToScreen());

    DrawText($"Tower world x: {(int)towerX}", ColorBlack(), "arial", 26, 30, 25, OptionToScreen());
    DrawText($"Tower screen x: {(int)towerScreenX}", ColorBlack(), "arial", 26, 30, 65, OptionToScreen());
    DrawText("Left and right arrows move the camera", ColorGray(), "arial", 20, 30, 410, OptionToScreen());

    RefreshScreen(60);
}

CloseAllWindows();
