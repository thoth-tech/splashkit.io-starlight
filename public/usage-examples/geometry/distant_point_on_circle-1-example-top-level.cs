using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Distant Point On Circle", 800, 600);

Point2D cursorPos;
Circle circleShape = CircleAt(PointAt(400, 200), 100);
Point2D distantPointCoordinates;

while (!QuitRequested())
{
    ProcessEvents();
    cursorPos = MousePosition();

    // Point2D variable stores the x and y coordinates of the furthest point between the circle and mouse cursor
    distantPointCoordinates = DistantPointOnCircle(cursorPos, circleShape);

    ClearScreen();
    DrawCircle(ColorBlack(), circleShape);
    FillCircle(ColorRed(), CircleAt(distantPointCoordinates, 5));
    DrawText($"Most distant point on circle's circumference from mouse cursor is: {(int)distantPointCoordinates.X}, {(int)distantPointCoordinates.Y}", ColorBlack(), 100, 500);
                
    RefreshScreen();
}
CloseAllWindows();