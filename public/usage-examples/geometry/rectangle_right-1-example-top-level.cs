using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Sliding Right Edge", 800, 600);

// Slide the rectangle side to side so the right edge keeps moving
double boxX = 150;
double slideStep = 2;

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    Rectangle box = RectangleFrom(boxX, 200, 300, 200);

    // The right edge is the left plus the width, so SplashKit works it out for us
    double rightEdge = RectangleRight(box);

    DrawRectangle(ColorBlack(), box);
    DrawLine(ColorRed(), rightEdge, 0, rightEdge, 600);
    DrawText($"Rectangle Right: {(int)rightEdge}", ColorBlack(), 50, 50);

    // Turn around at each end so the rectangle stays on screen
    boxX = boxX + slideStep;
    if (boxX > 350 || boxX < 150)
    {
        slideStep = -slideStep;
    }

    RefreshScreen(60);
}

CloseAllWindows();
