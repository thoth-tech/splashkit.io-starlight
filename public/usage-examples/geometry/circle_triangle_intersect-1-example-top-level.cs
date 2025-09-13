using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Intruder Alert!!", 800, 600);

// Declaring variables
Point2D p1 = PointAt(400, 200);
Point2D p2 = PointAt(300, 400);
Point2D p3 = PointAt(500, 400);
Triangle house = TriangleFrom(p1, p2, p3);
Point2D curosrPosition;
Circle intruder;
Color flash = ColorRed();

while (!QuitRequested())
{
    ProcessEvents();

    // Get mouse position
    curosrPosition = MousePosition();
    intruder = CircleAt(curosrPosition, 20);

    if (CircleTriangleIntersect(intruder, house))
    {
        ClearScreen(flash);
        DrawText("House Breached!!", ColorBlack(), 350, 100);

        // Toggle flash color
        if (flash == ColorRed())
        {
            flash = ColorBlue();
        }
        else
        {
            flash = ColorRed();
        }
        Delay(500);
    }
    else
    {
        ClearScreen(ColorWhite());
    }

    DrawTriangle(ColorBlack(), house);
    FillCircle(ColorBlack(), intruder);
    RefreshScreen();
}
CloseAllWindows();
