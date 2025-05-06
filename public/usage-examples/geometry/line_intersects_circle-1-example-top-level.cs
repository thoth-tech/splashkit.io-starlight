using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Interaction of Line and Circle", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    //Defining line and circle
    Point2D cursorPos = MousePosition();
    Line line = LineFrom(PointAt(150, 100), cursorPos);
    Circle circle = CircleAt(400, 300, 100);

    ClearScreen();

    //Drawing line and circle
    DrawLine(ColorBlue(), line);
    DrawCircle(ColorBlack(), circle);

    //Check for intersection and display the results
    if (LineIntersectsCircle(line, circle))
    {
        DrawText("Line and Circle intersect", ColorGreen(), 400, 100);
    }
    else
    {
        DrawText("Line and Circle do not intersect", ColorRed(), 400, 100);
    }

    RefreshScreen();
}

CloseAllWindows();
