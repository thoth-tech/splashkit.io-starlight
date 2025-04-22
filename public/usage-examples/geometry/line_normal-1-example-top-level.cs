using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Line Normal", 800, 600);

Line userLine;
Line xAxisLine;
Line yAxisLine;
Point2D cursorPos;
Vector2D vector;

while (!QuitRequested())
{
    ProcessEvents();
    cursorPos = MousePosition();
    userLine = LineFrom(PointAt(400, 350), cursorPos);

    xAxisLine = LineFrom(PointAt(cursorPos.X, 350), PointAt(400, 350));
    yAxisLine = LineFrom(PointAt(400, cursorPos.Y), PointAt(400, 350));

    // The line normal of the desired line is stored under the vector 2d variable
    vector = LineNormal(userLine);

    ClearScreen();
    DrawLine(Color.Black, userLine);
    DrawLine(Color.Red, xAxisLine);
    DrawLine(Color.Red, yAxisLine);
    DrawText("The black line's normal is: " + vector.X.ToString() + "," + vector.Y.ToString(), Color.Black, 60, 500);

    RefreshScreen();
}
CloseAllWindows();