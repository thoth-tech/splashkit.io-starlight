using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Flag of Japan", 600, 400);

// Create a circle at (300, 200) with radius 120
Circle myCircle = CircleAt(300, 200, 120);

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    // Draw the circle
    FillCircle(ColorDarkRed(), myCircle);

    RefreshScreen(60);
}

CloseAllWindows();
