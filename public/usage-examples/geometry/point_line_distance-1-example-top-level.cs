using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Distance from Mouse to Line", 800, 600);

// Use one fixed line and let the mouse act as the test point
Line demoLine = LineFrom(150, 300, 650, 300);

while (!QuitRequested())
{
    ProcessEvents();

    // Measure how far the mouse point is from the line
    Point2D pt = MousePosition();
    float distance = PointLineDistance(pt, demoLine);

    ClearScreen(ColorWhite());

    // Draw the line, the point, and the measured distance
    DrawLine(ColorBlack(), demoLine);
    FillCircle(ColorRed(), pt.X, pt.Y, 6);

    DrawText("Move the mouse to change the point.", ColorBlack(), 20, 20);
    DrawText("Distance from point to line: " + distance.ToString(), ColorBlue(), 20, 50);

    RefreshScreen(60);
}