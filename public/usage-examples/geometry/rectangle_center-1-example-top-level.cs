using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Tracking the Center Point", 800, 600);

// Slide the rectangle diagonally so the center point keeps moving
double boxX = 150;
double boxY = 100;
double slideStep = 2;

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    Rectangle box = RectangleFrom(boxX, boxY, 300, 200);

    // The center is half the width and half the height in from the corner
    Point2D center = RectangleCenter(box);

    DrawRectangle(ColorBlack(), box);
    FillCircle(ColorRed(), center.X, center.Y, 8);
    DrawText($"Rectangle Center: ({(int)center.X}, {(int)center.Y})", ColorBlack(), 50, 50);

    // Turn around at each end so the rectangle stays on screen
    boxX = boxX + slideStep;
    boxY = boxY + slideStep;
    if (boxX > 350 || boxX < 150)
    {
        slideStep = -slideStep;
    }

    RefreshScreen(60);
}

CloseAllWindows();
