using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Rectangle Intersection Demo", 800, 600);

Rectangle fixedRectangle = RectangleFrom(300, 220, 200, 120);

while (!QuitRequested())
{
    ProcessEvents();

    // Move the second rectangle with the mouse to test for intersections.
    Rectangle movableRectangle = RectangleFrom(
        MouseX() - 75,
        MouseY() - 50,
        150,
        100
    );

    // Check whether the two rectangles intersect.
    bool isIntersecting = RectanglesIntersect(
        fixedRectangle,
        movableRectangle
    );

    ClearScreen(Color.White);

    if (isIntersecting)
    {
        FillRectangle(Color.Red, fixedRectangle);
        FillRectangle(Color.Red, movableRectangle);

        DrawText(
            "Rectangles are intersecting.",
            Color.Black,
            240,
            60
        );
    }
    else
    {
        FillRectangle(Color.Blue, fixedRectangle);
        FillRectangle(Color.Green, movableRectangle);

        DrawText(
            "Move the green rectangle with the mouse.",
            Color.Black,
            185,
            60
        );
    }

    RefreshScreen(60);
}

CloseAllWindows();