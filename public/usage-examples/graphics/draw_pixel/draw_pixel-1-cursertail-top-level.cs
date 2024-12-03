using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Declare variables
const int TrailLength = 50;
Point2D MousePoint;
Point2D[] MouseHistory = new Point2D[TrailLength];
Color[] ColorList = { ColorBlue(), ColorRed(), ColorGreen(), ColorYellow(), ColorPink() };

OpenWindow("Cursor Trail", 600, 600);

while (!QuitRequested())
{
    MousePoint = MousePosition();
    ClearScreen(ColorBlack());

    // Set mouse position history
    for (int i = 0; i < TrailLength - 1; i++)
    {
        // Shuffle forward
        MouseHistory[i] = MouseHistory[i + 1];
    }

    MouseHistory[TrailLength - 1] = MousePoint;

    // Draw mouse trail
    for (int i = 0; i < TrailLength; i++)
    {
        DrawPixel(ColorList[i % 5], MouseHistory[i]);
    }

    ProcessEvents();
    RefreshScreen(60);
}

CloseAllWindows();
