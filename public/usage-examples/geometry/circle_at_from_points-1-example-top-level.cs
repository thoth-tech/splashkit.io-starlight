using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Blue Circle at the centre", 800, 600);

// Create a circle at (400, 300) with radius 100
Circle myCircle = CircleAt(400, 300, 100);

while (!WindowCloseRequested("Blue Circle at the centre"))
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    // Draw the circle
    FillCircle(ColorBlue(), myCircle);

    RefreshScreen(60);
}

CloseAllWindows();
