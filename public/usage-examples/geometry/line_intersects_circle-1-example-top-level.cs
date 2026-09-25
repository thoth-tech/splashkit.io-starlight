using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Line Intersects Circle", 800, 600);

Circle demoCircle = CircleAt(400, 300, 120);

while (!QuitRequested())
{
    ProcessEvents();

    // Create a line from a fixed point to the mouse position
    Point2D startPt = PointAt(100, 300);
    Point2D endPt = MousePosition();

    Line demoLine = LineFrom(startPt, endPt);

    // Check if the line intersects the circle
    bool intersects = LineIntersectsCircle(demoLine, demoCircle);

    ClearScreen(ColorWhite());

    // Draw the circle
    DrawCircle(ColorBlack(), demoCircle);

    // Draw the line based on intersection result
    if (intersects)
    {
        DrawLine(ColorGreen(), demoLine);
        DrawText("The line intersects the circle.", ColorGreen(), 20, 20);
    }
    else
    {
        DrawLine(ColorRed(), demoLine);
        DrawText("The line does not intersect the circle.", ColorRed(), 20, 20);
    }

    RefreshScreen(60);
}