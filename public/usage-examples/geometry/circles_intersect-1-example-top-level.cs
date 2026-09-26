using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Circle Intersection Demo", 800, 600);

Circle fixedCircle = CircleAt(350, 280, 100);

while (!QuitRequested())
{
    ProcessEvents();

    // Move the second circle with the mouse to test for intersections.
    Circle movableCircle = CircleAt(MouseX(), MouseY(), 70);

    // Check whether the two circles intersect.
    bool isIntersecting = CirclesIntersect(fixedCircle, movableCircle);

    ClearScreen(ColorWhite());

    if (isIntersecting)
    {
        FillCircle(ColorRed(), fixedCircle);
        FillCircle(ColorRed(), movableCircle);
        DrawText("Circles are intersecting!", ColorBlack(), 20, 20);
    }
    else
    {
        FillCircle(ColorBlue(), fixedCircle);
        FillCircle(ColorGreen(), movableCircle);
        DrawText("Circles are not intersecting.", ColorBlack(), 20, 20);
    }

    DrawText(
        "Move the mouse-controlled circle over the fixed circle.",
        ColorBlack(),
        20,
        550
    );

    RefreshScreen(60);
}

CloseAllWindows();