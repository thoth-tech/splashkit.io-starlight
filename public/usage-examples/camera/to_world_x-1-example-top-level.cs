using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Crosshair Ruler", 800, 450);

// The crosshair stays in the middle of the window, at this screen position
double crosshairX = 400;

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

    // The ruler is part of the world, so it slides with the camera
    for (int tick = -1000; tick <= 3000; tick += 100)
    {
        DrawLine(ColorGray(), tick, 150, tick, 300);
        DrawText(tick.ToString(), ColorBlack(), "arial", 18, tick + 5, 305);
    }

    // The crosshair is drawn with OptionToScreen() so the camera does not move it
    DrawLine(ColorRed(), crosshairX, 70, crosshairX, 395, OptionToScreen());

    // Turn the crosshair's screen position back into a position in the world
    double crosshairWorldX = ToWorldX(crosshairX);

    DrawText($"World x under the crosshair: {(int)crosshairWorldX}", ColorBlack(), "arial", 26, 30, 25, OptionToScreen());
    DrawText("Left and right arrows move the camera", ColorGray(), "arial", 20, 30, 410, OptionToScreen());

    RefreshScreen(60);
}

CloseAllWindows();
