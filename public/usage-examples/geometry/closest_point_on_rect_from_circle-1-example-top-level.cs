using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window window = new Window("Closest Point On Rect From Circle", 800, 600);

// Rectangle for creating the point on
Rectangle rectangleObj = RectangleFrom(300, 200, 200, 150);

while (!window.CloseRequested)
{
    ProcessEvents();
    ClearScreen(ColorWhite());
    DrawRectangle(ColorBlack(), rectangleObj);

    // Create circle at mouse position to make it dynamic
    Point2D mousePos = MousePosition();
    Circle circleObj = CircleAt(mousePos, 30);
    FillCircle(ColorRed(), circleObj);

    // Get closest point on the rect to the circle and draw it
    Point2D closestPoint = ClosestPointOnRectFromCircle(circleObj, rectangleObj);
    Circle pointOnRect = CircleAt(closestPoint, 5);
    FillCircle(ColorGreen(), pointOnRect);

    RefreshScreen();
}
