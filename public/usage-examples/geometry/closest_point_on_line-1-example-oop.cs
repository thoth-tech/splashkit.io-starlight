using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window window = new Window("Magnetic Point", 600, 600);
Line line = LineFrom(100, 100, 500, 400);

while (!window.CloseRequested())
{
    ProcessEvents();

    Point2D mouse = MousePosition();
    Point2D closest = ClosestPointOnLine(mouse, line);

    ClearScreen(COLOR_WHITE);
    DrawLine(COLOR_BLACK, line);
    FillCircle(COLOR_BLUE, mouse.X, mouse.Y, 5);
    FillCircle(COLOR_RED, closest.X, closest.Y, 5);
    DrawLine(COLOR_GRAY, mouse.X, mouse.Y, closest.X, closest.Y);
    DrawText("Mouse: " + mouse.ToString(), COLOR_BLACK, 20, 520);
    DrawText("Closest: " + closest.ToString(), COLOR_RED, 20, 540);

    RefreshScreen();
}

window.Close();


