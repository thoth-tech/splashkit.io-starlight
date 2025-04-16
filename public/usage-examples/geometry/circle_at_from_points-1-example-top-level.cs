using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a window and draw the circle
OpenWindow("Circle At Example", 800, 600);
Circle myCircle = CircleAt(400, 300, 100);

while (!WindowCloseRequested("Circle At Example"))
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    // Draw the circle
    FillCircle(ColorBlue(), myCircle);

    RefreshScreen(60);
}

CloseAllWindows();
