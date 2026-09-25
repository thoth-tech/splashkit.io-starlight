using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Sliding Top Edge", 800, 600);

// Slide the rectangle up and down so the top edge keeps moving
double boxY = 100;
double slideStep = 2;

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    Rectangle box = RectangleFrom(250, boxY, 300, 200);

    // Ask SplashKit where the top edge sits, then mark it across the window
    double topEdge = RectangleTop(box);

    DrawRectangle(ColorBlack(), box);
    DrawLine(ColorRed(), 0, topEdge, 800, topEdge);
    DrawText($"Rectangle Top: {(int)topEdge}", ColorBlack(), 50, 50);

    // Turn around at each end so the rectangle stays on screen
    boxY = boxY + slideStep;
    if (boxY > 300 || boxY < 100)
    {
        slideStep = -slideStep;
    }

    RefreshScreen(60);
}

CloseAllWindows();
