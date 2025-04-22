using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Closest Point On Line From Circle", 800, 600);

Point2D cursorPos;
Point2D closestPointCoordinates;
Point2D lineStart = PointAt(300, 400);
Circle circleShape = CircleAt(PointAt(250, 150), 100);
Line lineShape;

while (!QuitRequested())
{
    ProcessEvents();
    cursorPos = MousePosition();
    lineShape = LineFrom(lineStart, cursorPos);

    // Point2D variable stores the x and y coordinates of the closest point between the circle and line
    closestPointCoordinates = ClosestPointOnLineFromCircle(circleShape, lineShape);

    ClearScreen();
    DrawCircle(ColorBlack(), circleShape);
    DrawLine(ColorBlack(), lineShape);
    FillCircle(ColorRed(), CircleAt(closestPointCoordinates, 5));

    DrawText("Position of closest point on line from circle: " + PointToString(closestPointCoordinates), ColorBlack(), 110, 500);
    RefreshScreen();
}
CloseAllWindows();