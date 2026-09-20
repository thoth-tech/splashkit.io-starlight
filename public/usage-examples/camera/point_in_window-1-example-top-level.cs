using SplashKitSDK;
using static SplashKitSDK.SplashKit;

int windowWidth = 800;
double pointX = -30;
double movementSpeed = 2;
Window demoWindow = OpenWindow("Moving Point Boundary Check", windowWidth, 500);

while (!QuitRequested())
{
    ProcessEvents();

    // Move the point across both window boundaries to show both results.
    pointX += movementSpeed;
    if (pointX > windowWidth + 30)
    {
        pointX = -30;
    }

    Point2D testPoint = PointAt(pointX, 300);
    bool pointIsInside = PointInWindow(demoWindow, testPoint);

    ClearScreen(RGBColor(24, 31, 46));
    DrawText("POINT IN WINDOW", ColorWhite(), 315, 70);
    DrawText("The yellow point moves through the window boundaries.", ColorWhite(), 225, 120);
    DrawText("point_in_window result:", ColorWhite(), 300, 185);

    if (pointIsInside)
    {
        DrawText("TRUE - POINT IS INSIDE", ColorGreen(), 300, 225);
        FillCircle(ColorYellow(), testPoint, 15);
    }
    else
    {
        DrawText("FALSE - POINT IS OUTSIDE", ColorRed(), 295, 225);
    }

    DrawLine(ColorWhite(), 0, 300, windowWidth, 300);
    DrawText("Close the window to finish.", ColorWhite(), 310, 430);

    // A steady refresh rate keeps the movement easy to follow.
    RefreshScreen(60);
}

CloseAllWindows();
