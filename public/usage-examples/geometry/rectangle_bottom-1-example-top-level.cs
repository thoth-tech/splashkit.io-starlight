using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Sliding Bottom Edge", 800, 600);

// Slide the rectangle up and down so the bottom edge keeps moving
double boxY = 100;
double slideStep = 2;

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    Rectangle box = RectangleFrom(250, boxY, 300, 200);

    // The bottom edge is the top plus the height, so SplashKit works it out for us
    double bottomEdge = RectangleBottom(box);

    DrawRectangle(ColorBlack(), box);
    DrawLine(ColorRed(), 0, bottomEdge, 800, bottomEdge);
    DrawText($"Rectangle Bottom: {(int)bottomEdge}", ColorBlack(), 50, 50);

    // Turn around at each end so the rectangle stays on screen
    boxY = boxY + slideStep;
    if (boxY > 300 || boxY < 100)
    {
        slideStep = -slideStep;
    }

    RefreshScreen(60);
}

CloseAllWindows();
