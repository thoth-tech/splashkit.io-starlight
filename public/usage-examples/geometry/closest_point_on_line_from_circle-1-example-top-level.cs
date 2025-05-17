using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Closest Point On Line From Circle", 800, 600);

Point2D cursorPos;
Point2D closestPointCoordinates;
Point2D lineStart = PointAt(300, 400);
Circle circleShape = CircleAt(PointAt(250, 150), 100);
Circle redDot;
Line lineShape;

while (!QuitRequested())
{
    ProcessEvents();
    cursorPos = MousePosition();
    lineShape = LineFrom(lineStart, cursorPos);
                
    // Point2D variable stores the x and y coordinates of the closest point between the circle and line
    closestPointCoordinates = ClosestPointOnLineFromCircle(circleShape, lineShape);
    redDot = CircleAt(closestPointCoordinates, 5);

    ClearScreen();
    DrawCircle(Color.Black, circleShape);
    DrawLine(Color.Black, lineShape);
    FillCircle(Color.Red, redDot);

    DrawText("Position of closest point on line from circle: " + PointToString(closestPointCoordinates), Color.Black, 110, 500);
    RefreshScreen();
}
CloseAllWindows();