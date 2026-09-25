using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Depth Gauge", 800, 450);

// The crosshair stays in the middle of the window, at this screen position
double crosshairY = 225;

while (!QuitRequested())
{
    ProcessEvents();

    // The arrow keys slide the camera up and down the world
    if (KeyDown(KeyCode.UpKey))
    {
        MoveCameraBy(0, -4);
    }

    if (KeyDown(KeyCode.DownKey))
    {
        MoveCameraBy(0, 4);
    }

    ClearScreen(ColorWhite());

    // The gauge is part of the world, so it slides with the camera
    for (int tick = -1000; tick <= 3000; tick += 100)
    {
        DrawLine(ColorGray(), 480, tick, 680, tick);
        DrawText(tick.ToString(), ColorBlack(), "arial", 18, 690, tick - 10);
    }

    // The crosshair is drawn with OptionToScreen() so the camera does not move it
    DrawLine(ColorRed(), 0, crosshairY, 800, crosshairY, OptionToScreen());

    // Turn the crosshair's screen position back into a position in the world
    double crosshairWorldY = ToWorldY(crosshairY);

    DrawText($"World y under the crosshair: {(int)crosshairWorldY}", ColorBlack(), "arial", 26, 30, 25, OptionToScreen());
    DrawText("Up and down arrows move the camera", ColorGray(), "arial", 20, 30, 410, OptionToScreen());

    RefreshScreen(60);
}

CloseAllWindows();
