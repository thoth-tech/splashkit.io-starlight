using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Point On Screen Example", 400, 300);

// Load the font used to display the visibility status text
Font statusFont = LoadFont("StatusFont", "DejaVuSans.ttf");

// A fixed point in the world we will check each frame
Point2D worldPoint = PointAt(500, 100);

double cameraX = 0;

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(Color.White);

    // Move the camera position each frame
    SetCameraPosition(PointAt(cameraX, 0));
    cameraX += 5;

    // Draw a circle at the fixed world point - it does not move itself
    FillCircle(Color.Red, worldPoint, 20);

    // Convert the world point to screen coordinates, then check visibility
    // The text is drawn to_screen so it stays fixed and does not scroll with the camera
    if (PointOnScreen(ToScreen(worldPoint)))
    {
        DrawText("Point On Screen: TRUE", Color.Black, statusFont, 20, 10, 10, OptionToScreen());
    }
    else
    {
        DrawText("Point On Screen: FALSE", Color.Black, statusFont, 20, 10, 10, OptionToScreen());
    }

    RefreshScreen(60);
}

CloseAllWindows();