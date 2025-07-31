using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Point of Attraction", 800, 600);

//Declaring line and variable points
Point2D cursorPos;
Point2D closestPoint;
Line line = LineFrom(150, 150, 500, 500);

while (!QuitRequested())
{
    ProcessEvents();

    cursorPos = MousePosition();
    closestPoint = ClosestPointOnLine(cursorPos, line);

    //Draw the line and display results
    ClearScreen();
    DrawLine(ColorBlack(), line);
    FillCircle(ColorRed(), cursorPos.X, cursorPos.Y, 5);
    FillCircle(ColorBlue(), closestPoint.X, closestPoint.Y, 5);
    DrawLine(ColorGreen(), cursorPos, closestPoint);
    DrawText("Cursor Position: " + PointToString(cursorPos), ColorBlack(), 20, 40);
    DrawText("Closest Point on Line: " + PointToString(closestPoint), ColorBlack(), 20, 80);
    RefreshScreen();
}
CloseAllWindows();
