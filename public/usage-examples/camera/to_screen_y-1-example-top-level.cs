using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Balloon Height", 800, 450);

// The balloon stays at this world position, wherever the camera is looking
double balloonX = 600;
double balloonY = 225;

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

    // Shapes are drawn in world coordinates, so they slide across the window with the camera
    DrawLine(ColorGray(), 400, 420, 800, 420);
    DrawLine(ColorGray(), balloonX, balloonY + 40, balloonX, 420);
    FillCircle(ColorRed(), balloonX, balloonY, 40);

    // Ask the camera where the balloon's world position appears on the screen
    double balloonScreenY = ToScreenY(balloonY);

    // A marker at that screen position, drawn with OptionToScreen() so the camera does not move it
    DrawLine(ColorBlue(), 380, balloonScreenY, 800, balloonScreenY, OptionToScreen());

    DrawText($"Balloon world y: {(int)balloonY}", ColorBlack(), "arial", 26, 30, 25, OptionToScreen());
    DrawText($"Balloon screen y: {(int)balloonScreenY}", ColorBlack(), "arial", 26, 30, 65, OptionToScreen());
    DrawText("Up and down arrows move the camera", ColorGray(), "arial", 20, 30, 410, OptionToScreen());

    RefreshScreen(60);
}

CloseAllWindows();
