using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Sliding Left Edge", 800, 600);

// Slide the rectangle side to side so the left edge keeps moving
double boxX = 150;
double slideStep = 2;

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    Rectangle box = RectangleFrom(boxX, 200, 300, 200);

    // Ask SplashKit where the left edge sits, then mark it down the window
    double leftEdge = RectangleLeft(box);

    DrawRectangle(ColorBlack(), box);
    DrawLine(ColorRed(), leftEdge, 0, leftEdge, 600);
    DrawText($"Rectangle Left: {(int)leftEdge}", ColorBlack(), 50, 50);

    // Turn around at each end so the rectangle stays on screen
    boxX = boxX + slideStep;
    if (boxX > 350 || boxX < 150)
    {
        slideStep = -slideStep;
    }

    RefreshScreen(60);
}

CloseAllWindows();
